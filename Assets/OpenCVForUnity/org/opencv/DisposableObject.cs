using UnityEngine;

using System;

namespace OpenCVForUnity
{
		abstract public class DisposableObject : IDisposable
		{

				public bool IsDisposed { get; protected set; }
		
				public bool IsEnabledDispose { get; set; }
				
				protected DisposableObject ()
            : this(true)
				{
				}
			
				protected DisposableObject (bool isEnabledDispose)
				{
						IsEnabledDispose = isEnabledDispose;
						IsDisposed = false;
				}

				public void Dispose ()
				{
						Dispose (true);
						GC.SuppressFinalize (this);
				}

				protected virtual void Dispose (bool disposing)
				{
						if (!IsDisposed) {             
						
								if (disposing) {
								}

								IsDisposed = true;
						}
				}

				~DisposableObject ()
				{
						Dispose (false);
				}

				public void ThrowIfDisposed ()
				{
						if (IsDisposed) 
								throw new ObjectDisposedException (GetType ().FullName);
				}
      
		}
}
