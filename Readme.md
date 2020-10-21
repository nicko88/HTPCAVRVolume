# HTPCAVRVolume

This is a simple program that captures your HTPC's volume control buttons and instead sends the commands directly to your
home theater AVR.

The main benefit of this is that most people when watching video on their HTPC use audio bit-streaming for things like
Dolby Digital and DTS audio formats.  When you are bit-streaming, the volume control on your HTPC does not work for the
bit-streamed audio.  This means you can't use the convienent volume control buttons on your wireless keyboard or
handheld remote control to control your playback volume.

##### Supported Controls

The only supported controls are:

* Volume Up
* Volume Down
* Mute/Unmute

### Supported AVRs

At this time, the only supported AVRs are modern Denon and Marantz units with network control.

Support for other AVRs could be pretty easily added to the existing code though.

### How To Use

Simply download the latest release, place the program .exe wherever you like, and run it.

After running it, select your AVR from the dropown and enter it's network IP address, then hit Save.

You can also add the program, or a shortcut to it to your HTPC's startup folder so that the program automatically
starts with your PC.