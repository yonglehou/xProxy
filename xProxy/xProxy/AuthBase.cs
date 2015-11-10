using System;
using System.Net;
using System.Net.Sockets;
using xProxy;
using xProxy.Socks;

namespace xProxy.Socks.Authentication {

internal delegate void AuthenticationCompleteDelegate(bool Success);

internal abstract class AuthBase {
	
	public AuthBase() {}

	internal abstract void StartAuthentication(Socket Connection, AuthenticationCompleteDelegate Callback);

	protected Socket Connection {
		get {
			return m_Connection;
		}
		set {
			if (value == null)
				throw new ArgumentNullException();
			m_Connection = value;
		}
	}
	
	
	protected byte [] Buffer {
		get {
			return m_Buffer;
		}
	}
	
	
	protected byte [] Bytes {
		get {
			return m_Bytes;
		}
		set {
			m_Bytes = value;
		}
	}
	
	
	
	protected void AddBytes(byte [] NewBytes, int Cnt) {
		if (Cnt <= 0 || NewBytes == null || Cnt > NewBytes.Length)
			return;
		if (Bytes == null) {
			Bytes = new byte[Cnt];
		} else {
			byte [] tmp = Bytes;
			Bytes = new byte[Bytes.Length  + Cnt];
			Array.Copy(tmp, 0, Bytes, 0, tmp.Length);
		}
		Array.Copy(NewBytes, 0, Bytes, Bytes.Length - Cnt, Cnt);
	}
	
	protected AuthenticationCompleteDelegate Callback;
	// private variables
	/// <summary>Holds the value of the Connection property.</summary>
	private Socket m_Connection;
	/// <summary>Holds the value of the Buffer property.</summary>
	private byte [] m_Buffer = new byte[1024];
	/// <summary>Holds the value of the Bytes property.</summary>
	private byte [] m_Bytes;
}

}
