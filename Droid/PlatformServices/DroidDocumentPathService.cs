using System;
using Yahooooo.Droid;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(DroidDocumentPathService))]
namespace Yahooooo.Droid
{
	public class DroidDocumentPathService
		: IDocumentPathService
	{
		public void SaveText (string filename, string text) {
			var documentsPath = DocumentsPath;
			var filePath = Path.Combine (documentsPath, filename);
			File.WriteAllText (filePath, text);
		}

		public string LoadText (string filename) {
			var documentsPath = DocumentsPath;
			var filePath = Path.Combine (documentsPath, filename);
			return File.ReadAllText (filePath);
		}

		public string CreateDocumentPath (string filename) {
			var documentsPath = DocumentsPath;
			var filePath = Path.Combine (documentsPath, filename);
			return filePath;
		}

		public void DeleteDocument (string filename) {
			var documentsPath = DocumentsPath;
			var filePath = Path.Combine (documentsPath, filename);
			File.Delete (filePath);
		}


		public bool FileExists (string filename)
		{
			return File.Exists (CreatePathToFile (filename));
		}

		public static string DocumentsPath {
			get {
				var documentsDirUrl = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
				return documentsDirUrl;
			}
		}

		static string CreatePathToFile(string fileName)
		{
			return Path.Combine (DocumentsPath, fileName);
		}

	}
}

