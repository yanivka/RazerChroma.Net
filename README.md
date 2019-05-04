# RazerChroma .NET

Very fast and close to the C++ implementation of the Razer Chroma API in C#

# Features!

  - Fully support all API calles in the native C++ API (With all the structs implemented in C#).
  - All supported devices information (includes names, id (Guid), description and device image).
  - Fast frame API for drawing frames on all of the supported devices (used for light animation).


# Easy to use API
### Basic API (Like in the C++ one)

1. Init the api, This will load the RazerChromSdk dll into your application.
```csharp
RazerChroma.Net.NativeRazerApi api = new RazerChroma.Net.NativeRazerApi();
```
2. Use the CreateEvent functions to craete events specifically to devices types (Keyboard, mouse, headset and more...)
```csharp
api.CreateKeyboardEffect();
api.CreateMouseEffect();
api.CreateHeadSetEffect();
api.CreateMousepadEffect();
api.CreateKeypadEffect();
api.CreateChromaLinkEffect();
```
3. Create the required effect for the given device type (Custom, wave and more...)
```csharp
Effect effect = api.CreateKeyboardEffect(
    new RazerChroma.Net.Keyboard.Effects.Static(
        new RazerChroma.Net.NativeWin32.ColorRef(255, 0, 0, 255))); // Static red keyboard effect
        
Effect effect = api.CreateMousepadEffect(
   new RazerChroma.Net.MousePad.Effects.Wave(
       RazerChroma.Net.MousePad.Effects.Wave._Direction.LeftToRight));
```
4. Activate the effect
```csharp
effect.Set()
```
  And you are done with controling your devices from C#.
  
  Note: if you are making alot of effects you should dispose old onces to free the handles to them.

### Fast frames 

1. Create frame for the given device type (Keyboard, mouse and more)
```csharp
RazerChromaFrameEngine.KeyboradFrame keyboardFrame = new RazerChromaFrameEngine.KeyboradFrame(api);
RazerChromaFrameEngine.MouseFrame mouseFrame = new RazerChromaFrameEngine.MouseFrame(api);
```
2. Use the SetKey and SetKeys functions to set colors to the required lights
```csharp
keyboardFrame.SetKey(0, 1, Color.Red);
keyboardFrame.SetKey(RazerChroma.Net.Keyboard.Definitions.RzKey.F, Color.Green);
keyboardFrame.SetKeys(1, 0, 2, 1, Color.Yellow);
mouseFrame.SetKey(RazerChroma.Net.Mouse.Definitions.RzLed2.Scrollwheel, Color.Purple);
```
3. Draw your frame to your devices 
```csharp
keyboardFrame.Update();
mouseFrame.Update();
```
Note: SetKey and SetKeys support transparency (Not like the basic API). 

# Pre-Requirements

- When creating a native api object, RazerChromaSDK.dll will be loaded.
If this dll is missing from your system a native windows error will be thrown.
You should fix this problem only by installing  [Razer Synapse](https://www.razer.com/synapse-3).

# License


MIT


**Free Software, Hell Yeah!**


