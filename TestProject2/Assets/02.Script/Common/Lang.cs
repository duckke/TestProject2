using System.Xml;
using System.Collections;
using UnityEngine;

namespace Etc.Classes.Lang {
	public class Lang {

		private Hashtable Strings;

		public Lang (string path, string language) {
			setLanguage (path, language);
		}

		public void setLanguage (string file_name, string language) {
			TextAsset textAsset = Resources.Load<TextAsset> (file_name);
			XmlDocument xml = new XmlDocument ();
			xml.LoadXml (textAsset.text);
			Strings = new Hashtable ();
			XmlElement root = xml.DocumentElement;
			XmlNodeList nodeList = root.GetElementsByTagName (language)[0].ChildNodes;
			foreach (XmlNode node in nodeList) {
				Strings.Add (node.Name, node.InnerText);
			}
		}

		public string getString(string name) {
			if (!Strings.ContainsKey (name))
				return "";

			return Strings[name].ToString();
		}
	}
}
