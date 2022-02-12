#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

namespace StarMap2D.Miscellaneous;

/// <summary>
/// A helper class to set text to the clipboard.
/// </summary>
internal class ClipboardAdder
{
    /// <summary>
    /// Sets the clipboard text.
    /// </summary>
    /// <param name="value">The value to set to the clipboard.</param>
    /// <param name="retryCount">The retry count to try to set the clipboard text.</param>
    /// <param name="sleepInterval">The interval to wait before retrying the clipboard set text operation in case of failure.</param>
    public static void SetClipboardText(string value, int retryCount = 10, int sleepInterval = 50)
    {
        for (var i = 0; i < retryCount; i++)
        {
            try
            {
                Clipboard.SetText(value);
                break;
            }
            catch
            {
                Thread.Sleep(sleepInterval);
                // Let the loop continue
            }
        }
    }
}