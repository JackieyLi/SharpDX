﻿// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#if !W8CORE
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormsKeys = System.Windows.Forms.Keys;

#if !W8CORE && NET35Plus && !DIRECTX11_1
using WpfKeys = System.Windows.Input.Key;
#endif

namespace SharpDX.Toolkit.Input
{
    /// <summary>
    /// A specific implementation of <see cref="KeyboardPlatform"/> for desktop platform
    /// </summary>
    internal sealed class KeyboardPlatformDesktop : KeyboardPlatform
    {
        // mapping between WinForms keys and toolkit keys
        private static readonly IDictionary<FormsKeys, Keys> _keysDictionaryForms;

        static KeyboardPlatformDesktop()
        {
            _keysDictionaryForms = new Dictionary<FormsKeys, Keys>();
            // the contents of this dictionary were autogenerated by comparing enum first by names, 
            // then, if no value is found, by int value.
            // the values that don't have a equivalent in either list are ignored.
            _keysDictionaryForms[FormsKeys.None] = Keys.None;
            _keysDictionaryForms[FormsKeys.Back] = Keys.Back;
            _keysDictionaryForms[FormsKeys.Tab] = Keys.Tab;
            _keysDictionaryForms[FormsKeys.Return] = Keys.Enter;
            _keysDictionaryForms[FormsKeys.Pause] = Keys.Pause;
            _keysDictionaryForms[FormsKeys.Capital] = Keys.CapsLock;
            _keysDictionaryForms[FormsKeys.KanaMode] = Keys.Kana;
            _keysDictionaryForms[FormsKeys.HanjaMode] = Keys.Kanji;
            _keysDictionaryForms[FormsKeys.Escape] = Keys.Escape;
            _keysDictionaryForms[FormsKeys.IMEConvert] = Keys.ImeConvert;
            _keysDictionaryForms[FormsKeys.IMENonconvert] = Keys.ImeNoConvert;
            _keysDictionaryForms[FormsKeys.Space] = Keys.Space;
            _keysDictionaryForms[FormsKeys.PageUp] = Keys.PageUp;
            _keysDictionaryForms[FormsKeys.Next] = Keys.PageDown;
            _keysDictionaryForms[FormsKeys.End] = Keys.End;
            _keysDictionaryForms[FormsKeys.Home] = Keys.Home;
            _keysDictionaryForms[FormsKeys.Left] = Keys.Left;
            _keysDictionaryForms[FormsKeys.Up] = Keys.Up;
            _keysDictionaryForms[FormsKeys.Right] = Keys.Right;
            _keysDictionaryForms[FormsKeys.Down] = Keys.Down;
            _keysDictionaryForms[FormsKeys.Select] = Keys.Select;
            _keysDictionaryForms[FormsKeys.Print] = Keys.Print;
            _keysDictionaryForms[FormsKeys.Execute] = Keys.Execute;
            _keysDictionaryForms[FormsKeys.PrintScreen] = Keys.PrintScreen;
            _keysDictionaryForms[FormsKeys.Insert] = Keys.Insert;
            _keysDictionaryForms[FormsKeys.Delete] = Keys.Delete;
            _keysDictionaryForms[FormsKeys.Help] = Keys.Help;
            _keysDictionaryForms[FormsKeys.D0] = Keys.D0;
            _keysDictionaryForms[FormsKeys.D1] = Keys.D1;
            _keysDictionaryForms[FormsKeys.D2] = Keys.D2;
            _keysDictionaryForms[FormsKeys.D3] = Keys.D3;
            _keysDictionaryForms[FormsKeys.D4] = Keys.D4;
            _keysDictionaryForms[FormsKeys.D5] = Keys.D5;
            _keysDictionaryForms[FormsKeys.D6] = Keys.D6;
            _keysDictionaryForms[FormsKeys.D7] = Keys.D7;
            _keysDictionaryForms[FormsKeys.D8] = Keys.D8;
            _keysDictionaryForms[FormsKeys.D9] = Keys.D9;
            _keysDictionaryForms[FormsKeys.A] = Keys.A;
            _keysDictionaryForms[FormsKeys.B] = Keys.B;
            _keysDictionaryForms[FormsKeys.C] = Keys.C;
            _keysDictionaryForms[FormsKeys.D] = Keys.D;
            _keysDictionaryForms[FormsKeys.E] = Keys.E;
            _keysDictionaryForms[FormsKeys.F] = Keys.F;
            _keysDictionaryForms[FormsKeys.G] = Keys.G;
            _keysDictionaryForms[FormsKeys.H] = Keys.H;
            _keysDictionaryForms[FormsKeys.I] = Keys.I;
            _keysDictionaryForms[FormsKeys.J] = Keys.J;
            _keysDictionaryForms[FormsKeys.K] = Keys.K;
            _keysDictionaryForms[FormsKeys.L] = Keys.L;
            _keysDictionaryForms[FormsKeys.M] = Keys.M;
            _keysDictionaryForms[FormsKeys.N] = Keys.N;
            _keysDictionaryForms[FormsKeys.O] = Keys.O;
            _keysDictionaryForms[FormsKeys.P] = Keys.P;
            _keysDictionaryForms[FormsKeys.Q] = Keys.Q;
            _keysDictionaryForms[FormsKeys.R] = Keys.R;
            _keysDictionaryForms[FormsKeys.S] = Keys.S;
            _keysDictionaryForms[FormsKeys.T] = Keys.T;
            _keysDictionaryForms[FormsKeys.U] = Keys.U;
            _keysDictionaryForms[FormsKeys.V] = Keys.V;
            _keysDictionaryForms[FormsKeys.W] = Keys.W;
            _keysDictionaryForms[FormsKeys.X] = Keys.X;
            _keysDictionaryForms[FormsKeys.Y] = Keys.Y;
            _keysDictionaryForms[FormsKeys.Z] = Keys.Z;
            _keysDictionaryForms[FormsKeys.LWin] = Keys.LeftWindows;
            _keysDictionaryForms[FormsKeys.RWin] = Keys.RightWindows;
            _keysDictionaryForms[FormsKeys.Apps] = Keys.Apps;
            _keysDictionaryForms[FormsKeys.Sleep] = Keys.Sleep;
            _keysDictionaryForms[FormsKeys.NumPad0] = Keys.NumPad0;
            _keysDictionaryForms[FormsKeys.NumPad1] = Keys.NumPad1;
            _keysDictionaryForms[FormsKeys.NumPad2] = Keys.NumPad2;
            _keysDictionaryForms[FormsKeys.NumPad3] = Keys.NumPad3;
            _keysDictionaryForms[FormsKeys.NumPad4] = Keys.NumPad4;
            _keysDictionaryForms[FormsKeys.NumPad5] = Keys.NumPad5;
            _keysDictionaryForms[FormsKeys.NumPad6] = Keys.NumPad6;
            _keysDictionaryForms[FormsKeys.NumPad7] = Keys.NumPad7;
            _keysDictionaryForms[FormsKeys.NumPad8] = Keys.NumPad8;
            _keysDictionaryForms[FormsKeys.NumPad9] = Keys.NumPad9;
            _keysDictionaryForms[FormsKeys.Multiply] = Keys.Multiply;
            _keysDictionaryForms[FormsKeys.Add] = Keys.Add;
            _keysDictionaryForms[FormsKeys.Separator] = Keys.Separator;
            _keysDictionaryForms[FormsKeys.Subtract] = Keys.Subtract;
            _keysDictionaryForms[FormsKeys.Decimal] = Keys.Decimal;
            _keysDictionaryForms[FormsKeys.Divide] = Keys.Divide;
            _keysDictionaryForms[FormsKeys.F1] = Keys.F1;
            _keysDictionaryForms[FormsKeys.F2] = Keys.F2;
            _keysDictionaryForms[FormsKeys.F3] = Keys.F3;
            _keysDictionaryForms[FormsKeys.F4] = Keys.F4;
            _keysDictionaryForms[FormsKeys.F5] = Keys.F5;
            _keysDictionaryForms[FormsKeys.F6] = Keys.F6;
            _keysDictionaryForms[FormsKeys.F7] = Keys.F7;
            _keysDictionaryForms[FormsKeys.F8] = Keys.F8;
            _keysDictionaryForms[FormsKeys.F9] = Keys.F9;
            _keysDictionaryForms[FormsKeys.F10] = Keys.F10;
            _keysDictionaryForms[FormsKeys.F11] = Keys.F11;
            _keysDictionaryForms[FormsKeys.F12] = Keys.F12;
            _keysDictionaryForms[FormsKeys.F13] = Keys.F13;
            _keysDictionaryForms[FormsKeys.F14] = Keys.F14;
            _keysDictionaryForms[FormsKeys.F15] = Keys.F15;
            _keysDictionaryForms[FormsKeys.F16] = Keys.F16;
            _keysDictionaryForms[FormsKeys.F17] = Keys.F17;
            _keysDictionaryForms[FormsKeys.F18] = Keys.F18;
            _keysDictionaryForms[FormsKeys.F19] = Keys.F19;
            _keysDictionaryForms[FormsKeys.F20] = Keys.F20;
            _keysDictionaryForms[FormsKeys.F21] = Keys.F21;
            _keysDictionaryForms[FormsKeys.F22] = Keys.F22;
            _keysDictionaryForms[FormsKeys.F23] = Keys.F23;
            _keysDictionaryForms[FormsKeys.F24] = Keys.F24;
            _keysDictionaryForms[FormsKeys.NumLock] = Keys.NumLock;
            _keysDictionaryForms[FormsKeys.Scroll] = Keys.Scroll;
            _keysDictionaryForms[FormsKeys.LShiftKey] = Keys.LeftShift;
            _keysDictionaryForms[FormsKeys.RShiftKey] = Keys.RightShift;
            _keysDictionaryForms[FormsKeys.LControlKey] = Keys.LeftControl;
            _keysDictionaryForms[FormsKeys.RControlKey] = Keys.RightControl;
            _keysDictionaryForms[FormsKeys.LMenu] = Keys.LeftAlt;
            _keysDictionaryForms[FormsKeys.RMenu] = Keys.RightAlt;
            _keysDictionaryForms[FormsKeys.BrowserBack] = Keys.BrowserBack;
            _keysDictionaryForms[FormsKeys.BrowserForward] = Keys.BrowserForward;
            _keysDictionaryForms[FormsKeys.BrowserRefresh] = Keys.BrowserRefresh;
            _keysDictionaryForms[FormsKeys.BrowserStop] = Keys.BrowserStop;
            _keysDictionaryForms[FormsKeys.BrowserSearch] = Keys.BrowserSearch;
            _keysDictionaryForms[FormsKeys.BrowserFavorites] = Keys.BrowserFavorites;
            _keysDictionaryForms[FormsKeys.BrowserHome] = Keys.BrowserHome;
            _keysDictionaryForms[FormsKeys.VolumeMute] = Keys.VolumeMute;
            _keysDictionaryForms[FormsKeys.VolumeDown] = Keys.VolumeDown;
            _keysDictionaryForms[FormsKeys.VolumeUp] = Keys.VolumeUp;
            _keysDictionaryForms[FormsKeys.MediaNextTrack] = Keys.MediaNextTrack;
            _keysDictionaryForms[FormsKeys.MediaPreviousTrack] = Keys.MediaPreviousTrack;
            _keysDictionaryForms[FormsKeys.MediaStop] = Keys.MediaStop;
            _keysDictionaryForms[FormsKeys.MediaPlayPause] = Keys.MediaPlayPause;
            _keysDictionaryForms[FormsKeys.LaunchMail] = Keys.LaunchMail;
            _keysDictionaryForms[FormsKeys.SelectMedia] = Keys.SelectMedia;
            _keysDictionaryForms[FormsKeys.LaunchApplication1] = Keys.LaunchApplication1;
            _keysDictionaryForms[FormsKeys.LaunchApplication2] = Keys.LaunchApplication2;
            _keysDictionaryForms[FormsKeys.Oem1] = Keys.OemSemicolon;
            _keysDictionaryForms[FormsKeys.Oemplus] = Keys.OemPlus;
            _keysDictionaryForms[FormsKeys.Oemcomma] = Keys.OemComma;
            _keysDictionaryForms[FormsKeys.OemMinus] = Keys.OemMinus;
            _keysDictionaryForms[FormsKeys.OemPeriod] = Keys.OemPeriod;
            _keysDictionaryForms[FormsKeys.OemQuestion] = Keys.OemQuestion;
            _keysDictionaryForms[FormsKeys.Oemtilde] = Keys.OemTilde;
            _keysDictionaryForms[FormsKeys.OemOpenBrackets] = Keys.OemOpenBrackets;
            _keysDictionaryForms[FormsKeys.Oem5] = Keys.OemPipe;
            _keysDictionaryForms[FormsKeys.Oem6] = Keys.OemCloseBrackets;
            _keysDictionaryForms[FormsKeys.Oem7] = Keys.OemQuotes;
            _keysDictionaryForms[FormsKeys.Oem8] = Keys.Oem8;
            _keysDictionaryForms[FormsKeys.OemBackslash] = Keys.OemBackslash;
            _keysDictionaryForms[FormsKeys.ProcessKey] = Keys.ProcessKey;
            _keysDictionaryForms[FormsKeys.Attn] = Keys.Attn;
            _keysDictionaryForms[FormsKeys.Crsel] = Keys.Crsel;
            _keysDictionaryForms[FormsKeys.Exsel] = Keys.Exsel;
            _keysDictionaryForms[FormsKeys.EraseEof] = Keys.EraseEof;
            _keysDictionaryForms[FormsKeys.Play] = Keys.Play;
            _keysDictionaryForms[FormsKeys.Zoom] = Keys.Zoom;
            _keysDictionaryForms[FormsKeys.Pa1] = Keys.Pa1;
            _keysDictionaryForms[FormsKeys.OemClear] = Keys.OemClear;
            _keysDictionaryForms[FormsKeys.ShiftKey] = Keys.Shift;
            _keysDictionaryForms[FormsKeys.ControlKey] = Keys.Control;
            _keysDictionaryForms[FormsKeys.Menu] = Keys.Alt;
        }

        /// <summary>
        /// Creates a new instance of <see cref="KeyboardPlatformDesktop"/> class
        /// </summary>
        /// <param name="nativeWindow">The native window object reference</param>
        /// <exception cref="ArgumentNullException">Is thrown when <paramref name="nativeWindow"/> is null</exception>
        public KeyboardPlatformDesktop(object nativeWindow) : base(nativeWindow) { }

        /// <summary>
        /// Derived classes should implement platform-specific event bindings in this method
        /// </summary>
        /// <param name="nativeWindow">The native window object reference</param>
        /// <exception cref="ArgumentNullException">Is thrown when <paramref name="nativeWindow"/> is null</exception>
        /// <exception cref="InvalidOperationException">Is thrown when <paramref name="nativeWindow"/> is of an unsupported type.</exception>
        protected override void BindWindow(object nativeWindow)
        {
            if (nativeWindow == null) throw new ArgumentNullException("nativeWindow");

            var control = nativeWindow as Control;
            if (control == null && nativeWindow is IntPtr)
            {
                control = Control.FromHandle((IntPtr)nativeWindow);
            }

            if (control != null)
            {
                control.PreviewKeyDown += HandlePreviewKeyDown;
                control.KeyDown += HandleKeyDown;
                control.KeyUp += HandleKeyUp;

                return;
            }

            throw new InvalidOperationException(string.Format("Unsupported native window: {0}", nativeWindow));
        }

        /// <summary>
        /// Handles the <see cref="Control.PreviewKeyDown"/> event
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">Pressed key is read from <see cref="PreviewKeyDownEventArgs.KeyCode"/> property</param>
        private void HandlePreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ProcessKeyEvent(e.KeyCode, RaiseKeyPressed);
        }

        /// <summary>
        /// Handles the <see cref="Control.KeyDown"/> event
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">Pressed key is read from <see cref="System.Windows.Forms.KeyEventArgs.KeyCode"/> property</param>
        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            ProcessKeyEvent(e.KeyCode, RaiseKeyPressed);
        }

        /// <summary>
        /// Handles the <see cref="Control.KeyUp"/> event
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">Released key is read from <see cref="KeyEventArgs.KeyCode"/> property</param>
        private void HandleKeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            ProcessKeyEvent(e.KeyCode, RaiseKeyReleased);
        }

        /// <summary>
        /// Translates the WinForms key to Toolkit key and invokes status change
        /// </summary>
        /// <remarks>For modifier keys (Shift, Control, Alt) will invoke its Left... analog additionally</remarks>
        /// <param name="keyCode">WinForms key code to be translated</param>
        /// <param name="keyAction">delegate to invoke with translated key</param>
        private static void ProcessKeyEvent(FormsKeys keyCode, Action<Keys> keyAction)
        {
            Keys translatedKey;
            if (!_keysDictionaryForms.TryGetValue(keyCode, out translatedKey))
                translatedKey = Keys.None;

            keyAction(translatedKey);

            // XNA doesn't have handless modifier keys, so we will map general keys to left ones:
            // TODO: consider P/Invoke to get pressed keys and/or determine which key was pressed
            switch (translatedKey)
            {
                case Keys.Shift:
                    keyAction(Keys.LeftShift);
                    break;
                case Keys.Control:
                    keyAction(Keys.LeftControl);
                    break;
                case Keys.Alt:
                    keyAction(Keys.LeftAlt);
                    break;
            }
        }
    }
}

#endif
