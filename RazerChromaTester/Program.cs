using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChroma.Net;
using RazerChroma.Net.Keyboard;
using System.Runtime.InteropServices;
using RazerChromaDevice;
using System.IO;
using System.Reflection;
using RazerChromaFrameEngine;
using System.Drawing;

namespace RazerChromaTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running!!");
            NativeRazerApi api = new NativeRazerApi();
            System.Threading.Thread.Sleep(1000);
            ChromaDevice[] allDevices = GetAllDevices();
            ChromaDevice[] connectedDevices = GetActiveDevices(allDevices, api);
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (ChromaDevice connectedDevice in connectedDevices)
                Console.WriteLine("Device detected: " + connectedDevice.Name);
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Setting keyboard color to yellow");
            api.CreateKeyboardEffect(new RazerChroma.Net.Keyboard.Effects.Static(new NativeWin32.ColorRef(255, 255, 0, 0))).Set();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Setting mouse color to red");
            api.CreateMouseEffect(new RazerChroma.Net.Mouse.Effects.Static(RazerChroma.Net.Mouse.Definitions.RzLed.All, new NativeWin32.ColorRef(255,0,0,0))).Set();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Setting headset color to green");
            api.CreateHeadSetEffect(new RazerChroma.Net.HeadSet.Effects.Static(new NativeWin32.ColorRef(0, 255, 0, 0))).Set();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Setting mousemat color to blue");
            api.CreateMousepadEffect(new RazerChroma.Net.MousePad.Effects.Static(new NativeWin32.ColorRef(0, 0, 255, 0))).Set();
            Console.ResetColor();


            Console.WriteLine("First test, Please check that your devices have the right light color, If you dont have that device it is ok.");
            Console.WriteLine("Done, Click an to Continue...");
            Console.ReadKey();

            KeyboradFrame keyboardFrame = new KeyboradFrame(api);
            MouseFrame mouseFrame = new MouseFrame(api);
            MousepadFrame mousepadFrame = new MousepadFrame(api);
            HeadsetFrame headsetFrame = new HeadsetFrame(api);
            keyboardFrame.SetKey(0, 1, Color.Red);
            keyboardFrame.SetKey(Definitions.RzKey.F, Color.Green);
            keyboardFrame.SetKeys(1, 0, 2, 1, Color.Yellow);
            mouseFrame.SetKey(RazerChroma.Net.Mouse.Definitions.RzLed2.Scrollwheel, Color.Purple);
            mousepadFrame.SetKeys(0, 5, Color.Green);
            headsetFrame.Set(Color.Red);

            headsetFrame.Update();
            mousepadFrame.Update();
            mouseFrame.Update();
            keyboardFrame.Update();
            Console.WriteLine("Done, Click an to Continue...");


            Console.ReadKey();

        }

        static ChromaDevice[] GetActiveDevices(ChromaDevice[] deviceSet, NativeRazerApi api)
        {
            List<ChromaDevice> connectedDevices = new List<ChromaDevice>();
            foreach(ChromaDevice device in deviceSet)
            {
                RazerChroma.Net.ChromaSDK.DeviceInfoType queryResult = api.TryQueryDevice(device.id, out bool Success);
                if (Success && queryResult.Connected > 0) connectedDevices.Add(device);
            }
            return connectedDevices.ToArray();
        }

        static ChromaDevice[] GetAllDevices()
        {
            DirectoryInfo currentFolder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            List<ChromaDevice> devices = new List<ChromaDevice>();
            foreach(Assembly assm in currentFolder.EnumerateFiles().Where((item) => Path.GetExtension(item.FullName).ToLower() == ".dll" && Path.GetExtension(Path.GetFileNameWithoutExtension(item.FullName)).ToLower() == ".device" ).Select((item) => Assembly.LoadFile(item.FullName)))
            {
                Console.WriteLine($"Loading devices from assembly: {assm.FullName}");
                ChromaDevice[] currentDevices = assm.GetTypes()
                    .Where((t) => typeof(ChromaDevice).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract && t.GetConstructor(Type.EmptyTypes) != null)
                    .Select((item) => Activator.CreateInstance(item))
                    .Cast<ChromaDevice>().ToArray();
                foreach (ChromaDevice singleDevice in currentDevices)
                    Console.WriteLine("   Device loaded: " + singleDevice.Name);
                devices.AddRange(currentDevices);

            }
            return devices.ToArray();
        }
    }
}
