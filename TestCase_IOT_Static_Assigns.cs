using System;
using System.IO;

/**
 * TestCase_IOT_Static_Assigns
 * <p/>
 * The results of assessing this file should be a input output stack trace leading from getVulnerableSource to
 * writeToVulnerableSink.  All methods in this class are static.  We use a temporary to store the source, making
 * this slightly more complex then the TestCase_IOT_Static class.
 * <p/>
 * Complexity: Easiest
 */
public class TestCase_IOT_Static_Assigns {
    public static void main(string[] args) {
        try {
            string source = getVulnerableSource(args[0]);
            writeToVulnerableSink(source);
        } catch (Exception e) {
			Console.Write(e.StackTrace);
        }
    }

    public static string getVulnerableSource(string file) {
		FileStream fis = new FileStream(file, FileMode.Open);
		StreamReader reader = new StreamReader(fis);
		char[] buffer = new char[100];
		reader.Read(buffer, 0, buffer.Length);
		fis.Close();

		return new string(buffer);
	}

    public static void writeToVulnerableSink(string str) {
		FileStream fos = new FileStream(str, FileMode.CreateNew);
		StreamWriter writer = new StreamWriter(fos);
		writer.Write(str);
		writer.Close();    
	}
}
