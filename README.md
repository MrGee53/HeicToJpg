# HEIC To JPG
This is a simple program I wrote to convert HEIC photos to JPG.

## Overview
I wrote this program because Windows expects me to pay to view HEIC photos, and I didn't want to do that.
It is writen using .NET and C# and uses Magick.NET to convert the images to JPG format.
I have only tested this program on Windows 10, but may work on other systems.

## Usage
**Using the Windows 10 release**
- Download the *HeicToJpg.zip* from [releases](https://github.com/MrGee53/HeicToJpg/releases)
- Unzip the file
- Open the folder you just extracted
- Put your *.HEIC* photos into the *input* folder
- Run *HeicToJpg.exe*
- All formated images will be in the *output* folder


**Using [.NET](https://dotnet.microsoft.com/) 6.0**
- Clone this repository
- Add all your .HEIC photos to the *input* folder
- run the command *dotnet run*
- All formated images will be in the *output* folder

## Credits
I used [Magick.NET](https://github.com/dlemstra/Magick.NET) under the [Apache License 2.0](https://github.com/dlemstra/Magick.NET/blob/main/License.txt)

MIT License

Copyright (c) 2021 Parker Stokes

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
