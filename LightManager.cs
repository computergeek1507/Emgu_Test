﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emgu_Test
{
	public class LightManager
	{
		readonly List<Light> _lights = new List<Light>();
		private readonly BindingSource _source = new BindingSource();

		public event EventHandler<string> MessageSent;

		int _index = 1;

		public LightManager()
		{
			_source.DataSource = _lights;
		}

		void OnMessageSent(string message) => MessageSent.Invoke(this, message);

		public bool AddLight(PointF loc, float size)
		{
			Point locI = Point.Round(loc);
		   //look if light is already in list
		   var oldL = _lights.Find(item => Math.Abs(item.Position.X - locI.X) < 10.0 && Math.Abs(item.Position.Y - locI.Y) < 10.0);

			if (oldL != null) {
				return false;
			}

			_lights.Add(new Light {

				Position = locI,
				Diameter = (int)Math.Round(size),
				Number = _index
			});
			++_index;
			_source.ResetBindings(false);
			return true;
		}

		public void Clear()
		{
			_lights.Clear();
			_index = 1;
			_source.ResetBindings(false);
		}

		public Light FindLight(int x, int y)
		{
			foreach (var node in _lights)
				if (x == node.ScalePos.X && y == node.ScalePos.Y)
					return node;

			return null;
		}

		public void ExportModel(string filename, int scale)
		{
			FileInfo file = new FileInfo(filename);
			var cm = "";
			//var size = GetBoundingSize(scale);
			int x_max = 0;
			int x_min = 100000;
			int y_max = 0;
			int y_min = 100000;
			foreach (var light in _lights)
			{
				x_max = Math.Max(x_max, light.Position.X);
				x_min = Math.Min(x_min, light.Position.X);
				y_max = Math.Max(y_max, light.Position.Y);
				y_min = Math.Min(y_min, light.Position.Y);
			}

			int x_dist = ((x_max - x_min + 1) / scale) + 1;
			int y_dist = ((y_max - y_min + 1) / scale) + 1;

			foreach (var light in _lights)
			{
				light.ScalePos = new Point((light.Position.X - x_min) / scale, (light.Position.Y - y_min) / scale);
			}

			for (var y = 0; y <= y_dist; y++)
			{
				for (var x = 0; x <= x_dist; x++)
				{
					var cell = "";
					Light lght = FindLight(x, y);
					if (lght != null)
					{
						cell = lght.Number.ToString();
					}
					cm += cell + ",";
				}
				cm += ";";
			}

			cm = cm.TrimEnd(';');

			using (var f = new StreamWriter(filename))
			{
				f.Write("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<custommodel \n");
				f.Write("name=\"{0}\" ", Path.GetFileNameWithoutExtension(file.Name));
				f.Write("parm1=\"{0}\" ", x_dist);
				f.Write("parm2=\"{0}\" ", y_dist);
				f.Write("StringType=\"RGB Nodes\" ");
				f.Write("Transparency=\"0\" ");
				f.Write("PixelSize=\"2\" ");
				f.Write("ModelBrightness=\"\" ");
				f.Write("Antialias=\"1\" ");
				f.Write("StrandNames=\"\" ");
				f.Write("NodeNames=\"\" ");

				f.Write("CustomModel=\"");
				f.Write(cm);
				f.Write("\" ");
				f.Write("SourceVersion=\"2021.27\" ");
				f.Write(" >\n");

				f.Write("</custommodel>");
				f.Close();
			}

			OnMessageSent("Saved: " + filename);
		}

		public List<Light> GetLights() { return _lights; }

		public BindingSource GetBinding()
		{
			return _source;
		}
	}
}
