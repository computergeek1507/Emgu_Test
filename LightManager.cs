using System;
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

		int _index = 0;

		public LightManager()
		{
			_source.DataSource = _lights;
		}

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
			_index = 0;
			_source.ResetBindings(false);
		}

		/// <summary>
		/// Find the Light obj matching the given X,Y coordinate pair.
		/// </summary>
		/// <returns>A reference to the Light</returns>
		public Light FindLight(int x, int y)
		{
			foreach (var node in _lights)
				if (x == node.ScalePos.X && y == node.ScalePos.Y)
					return node;

			return null;
		}

		public Tuple<int, int> GetBoundingSize(int scale)
		{
			int width = 0;
			int height = 0;
			foreach (var light in _lights)
			{
				width = Math.Max(width, light.Position.X);
				height = Math.Max(height, light.Position.Y);
				light.ScalePos = new Point (light.Position.X / scale, light.Position.Y / scale);
			}
			return Tuple.Create(width/scale, height/scale);
		}

		/// <summary>
		/// Get the bounding sizes for the xmodel based on the diameters of the blobs found.
		/// </summary>
		/// <returns>The width and height of the matrix size of the xmodel.</returns>
		public Tuple<int, int> GetBoundingSize_Diameter()
        {
			_lights.Sort(); //Sort based on the icomparable
			int smallestDiam = _lights[_lights.Count() - 1].Diameter;

			int scaler = 4; 
			int scale = smallestDiam / scaler; 
			
			return GetBoundingSize(scale);
		}

		public void ExportModel(string filename, int scale)
		{
			FileInfo file = new FileInfo(filename);
			var cm = "";
			//var size = GetBoundingSize(scale);
			var size = GetBoundingSize_Diameter();

			for (var x = 0; x <= size.Item1 + 1; x++)
			{
				for (var y = 0; y <= size.Item2 + 1; y++)
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
				f.Write("name=\"{0}\" ", file.Name);
				f.Write("parm1=\"{0}\" ", size.Item1);
				f.Write("parm2=\"{0}\" ", size.Item2);
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
		}

		public List<Light> GetLights() { return _lights; }

		public BindingSource GetBinding()
		{
			return _source;
		}
	}
}
