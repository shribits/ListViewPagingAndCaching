using System;

namespace Yahooooo
{
	public interface IDocumentPathService
	{
		void SaveText (string filename, string text);
		string LoadText (string filename);
		bool FileExists (string filename);
		string CreateDocumentPath (string filename);
		void DeleteDocument(string filename);
	}
}

