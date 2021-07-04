package api.xIPC;

import java.io.PrintStream;

public class PrintLib {
	protected PrintStream stream = System.out;
	public PrintStream getStream() { return this.stream; }
	public PrintLib(PrintStream stream) { this.stream = stream; }
	public PrintLib() {}
	
	public static void print(String msg, PrintStream stream) { stream.print(msg); }
	public static void print(PrintStream stream) { print("", stream); }
	public void print(String msg) { print(msg, this.stream); }
	public void print() { print("", this.stream); }
	
	public static void println(Object msg, PrintStream stream) { stream.println((String) msg); }
	public static void println(PrintStream stream) { println("", stream); }
	public void println(Object msg) { println(msg, this.stream); }
	public void println() { println("", this.stream); }
}
