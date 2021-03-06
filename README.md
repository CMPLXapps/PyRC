# xIPC

An independent messaging/bulletin board/IRC app.

Please don't clone or download the main branch unless you
know what you're doing; it's the source code. Instead, if
you just want to download and use the app, download the
build you want to use from the releases section and follow
the instructions below.

## You may need to jump through some hoops

If you're using Windows, you're fine. Every build comes Windows ready out of the box.

If you're using Linux or MacOS, the process isn't complicated, but you need to go through
an additional process.

### Setup Process

 * Windows:

 As before, xIPC comes Windows ready out of the box, you just need to run `xIPC.exe`

 * Linux:

1. Make sure you have the latest version of Python installed.

2. Install `mono` using your package manager.

On ArchLinux:
```
sudo pacman -Syy mono
```

3. Run `configure-for-linux`
```
./configure-for-linux
```

4. Run `eirc`
```
./eirc
```

 * MacOS:

1. Install Mono from this site: https://www.mono-project.com/download/stable/#download-mac

2. Run `xIPC.exe` using mono in the console
```
mono xIPC.exe
```
