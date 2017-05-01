using System;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FaltRP.Serialization
{
	/// <summary>
	/// Contains functionality to save and load unity objects to and from files
	/// </summary>
	public static class Serializer
	{
		/// <summary>
		/// Save a unity object to a file
		/// </summary>
		/// <param name="obj">Object to save</param>
		/// <param name="path">Path to save object to</param>
		/// <param name="filename">File name to save as</param>
		/// <param name="readable">Export with readable whitespace or compacted</param>
		/// <returns>Was the save successful</returns>
		public static bool SaveObject(Object obj, string path, string filename, bool readable = false)
		{
			if (string.IsNullOrEmpty(path)) return false;
			string data = JsonUtility.ToJson(obj, readable);
			return SaveText(data, path, filename);
		}

		/// <summary>
		/// Load a unity object from a file
		/// </summary>
		/// <typeparam name="T">Type of object to load</typeparam>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">File name to load</param>
		/// <returns>Loaded object, null if error</returns>
		public static T LoadObject<T>(string path, string filename) where T : Object
		{
			if (string.IsNullOrEmpty(path)) return null;
			string load = LoadText(path, filename);
			return JsonUtility.FromJson<T>(load);
		}

		/// <summary>
		/// Load a unity object from a file, overwriting an existing object
		/// </summary>
		/// <typeparam name="T">Type of object to load</typeparam>
		/// <param name="obj">Object to overwrite with loaded data</param>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">File name to load</param>
		/// <returns>Was the load successful</returns>
		public static bool LoadObjectInto<T>(T obj, string path, string filename) where T : Object
		{
			if (string.IsNullOrEmpty(path)) return false;
			string load = LoadText(path, filename);
			if (string.IsNullOrEmpty(load)) return false;
			JsonUtility.FromJsonOverwrite(load, obj);
			return true;
		}

		/// <summary>
		/// Save text to a file
		/// </summary>
		/// <param name="text">Text to save</param>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">File name to save with</param>
		/// <param name="overwrite">Should overwrite existing files</param>
		/// <returns>Was the save successful</returns>
		private static bool SaveText(string text, string path, string filename, bool overwrite = true)
		{
			if (string.IsNullOrEmpty(text)) return false;
			string fullpath = Path.Combine(path, filename);
			if (!overwrite && File.Exists(fullpath)) return false;
			try
			{
				Directory.CreateDirectory(path);
				File.WriteAllText(fullpath, text);
			}
			catch (Exception e)
			{
				Debug.LogError(e.Message);
				return false;
			}
			return File.Exists(fullpath);
		}

		/// <summary>
		/// Load text from a file
		/// </summary>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">File name to load from</param>
		/// <returns>Loaded text, null if error or non-existant</returns>
		private static string LoadText(string path, string filename)
		{
			string fullpath = Path.Combine(path, filename);
			if (!File.Exists(fullpath)) return null;
			string load;
			try
			{
				load = File.ReadAllText(fullpath);
			}
			catch (Exception e)
			{
				Debug.LogError(e.Message);
				return null;
			}
			return load;
		}
	}
}