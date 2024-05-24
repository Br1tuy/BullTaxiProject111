using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullTaxiProject11
{
    public partial class ActiveOrdersMapForm : Form
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> active_orders;
        string[] table_active_columns = new string[] { "Id", "OpeningTime", "StartingAddress", "FinalAddress" };
        string[] table_active_headers = new string[] { "Id", "Час відкриття", "Початкова адреса", "Кінцева адреса" };
        GMapOverlay markersOverlay = new GMapOverlay("markers");

        public ActiveOrdersMapForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            for (int c = 0; c < 4; c++)
            {
                Table.Columns.Add(table_active_columns[c], table_active_headers[c]);
            }

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            Map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            Map.MinZoom = 1;
            Map.MaxZoom = 20;
            Map.Zoom = 5;
            Map.Position = new GMap.NET.PointLatLng(0, 0);
            Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            Map.CanDragMap = true;
            Map.DragButton = MouseButtons.Left;
            Map.ShowCenter = false;
            Map.ShowTileGridLines = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void ViewActiveOrderButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://127.0.0.1:8000/active_orders_view/");

            var answer = ProgramClient.Client.GetAsync(uri).Result;

            try
            {
                active_orders = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(answer.Content.ReadAsStringAsync().Result);

                Table.Rows.Clear();


                if (active_orders != null)
                {
                    foreach (var items in active_orders)
                    {
                        Table.Invoke(new MethodInvoker(() => Table.Rows.Add(items.Key, items.Value["opening time"], items.Value["starting address"], items.Value["final address"])));
                    }

                    Table.Refresh();
                }
            }
            catch
            {
                dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);
                MessageBox.Show(dict["Message"]);
            }
        }

        private void SearhOnMapButton_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Введіть id.");
            }
            else if (active_orders.ContainsKey(ID.Text))
            {
                string[] coordinates = active_orders[ID.Text]["starting address coordinates"].Split(' ');
                float lat = float.Parse(coordinates[0].Replace('.', ','));
                float lon = float.Parse(coordinates[1].Replace('.', ','));

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                Map.Overlays.Add(markersOverlay);
                Map.Position = new PointLatLng(lat, lon);
                    Map.Zoom = 30;
            }
            else
            {
                MessageBox.Show("Неправильне id.");
            }
        }
    }
}
