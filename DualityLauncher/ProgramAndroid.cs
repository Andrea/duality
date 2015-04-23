﻿using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;
using OpenTK.Platform;
using OpenTK.Android;

using Android.Views;
using Android.Content;
using Android.Util;
using System.Diagnostics;


namespace DualityLauncher.Android
{
	public class ProgramAndroid : AndroidGameView
	{
		private static bool _isDebugging = false;
		private static bool _isProfiling = false;
		private static bool _isRunFromEditor = false;
		private Stopwatch _frameLimiterWatch = new Stopwatch();
		Random r = new Random();

		public ProgramAndroid (Context context) : base (context)
		{
		}

		// This gets called when the drawing surface is ready
		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
/* DEBT: waiting for Duality x 3
 */			
			_isDebugging = System.Diagnostics.Debugger.IsAttached ;// || args.Contains(DualityApp.CmdArgDebug);
//			isRunFromEditor = args.Contains(DualityApp.CmdArgEditor);
//			isProfiling = args.Contains(DualityApp.CmdArgProfiling);
			if (_isDebugging || _isRunFromEditor) ShowConsole();
		}

		private static bool hasConsole = false;
		public static void ShowConsole()
		{
			/* DEBT: Not sure we need this console
			 */			
			if (hasConsole) return;
		//	NativeMethods.AllocConsole();
			hasConsole = true;
		}

		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			base.OnUpdateFrame(e);

			if (!_isDebugging && !_isProfiling) // Don't limit frame rate when debugging or profiling.
			{
				//// Assure we'll at least wait 16 ms until updating again.
				//if (this.frameLimiterWatch.IsRunning)
				//{
				//    while (this.frameLimiterWatch.Elapsed.TotalSeconds < 0.016d) 
				//    {
				//        // Go to sleep if we'd have to wait too long
				//        if (this.frameLimiterWatch.Elapsed.TotalSeconds < 0.01d)
				//            System.Threading.Thread.Sleep(1);
				//    }
				//}

				// Give the processor a rest if we have the time, don't use 100% CPU even without VSync
				/* DEBT: waiting for Duality time is defined in duality, not sure what to do about VSync,
				 * is it available on android?
 */			
//				if (_frameLimiterWatch.IsRunning && this.VSync == VSyncMode.Off)
//				{
//					while (_frameLimiterWatch.Elapsed.TotalMilliseconds < Time.MsPFMult)
//					{
//						// Enough leftover time? Risk a millisecond sleep.
//						if (_frameLimiterWatch.Elapsed.TotalMilliseconds < Time.MsPFMult * 0.75f)
//							System.Threading.Thread.Sleep(1);
//					}
//				}
				_frameLimiterWatch.Restart();
			}

		}

		

		protected override void OnRenderFrame (FrameEventArgs e)
		{
			// you only need to call this if you have delegates
			// registered that you want to have called
			base.OnRenderFrame (e);

			GL.ClearColor ((float)r.NextDouble (), 0f, 0f, 0f);
			GL.Clear (ClearBufferMask.ColorBufferBit);

			SwapBuffers ();
		}

	}
}
