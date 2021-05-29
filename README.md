# PyRC

An independent messaging/bulletin board/IRC app.

## You may need to jump over some hoops

If you're using Windows, you're fine. Every build comes Windows compatible out-of-the-box.

If you're using Linux or MacOS, you need to use Mono.

### Setup Process

 * Windows:

 As before, eIRC comes Windows ready out of the box, you just need to run `eIRC.exe`

 * Linux:

1. Make sure you have the latest version of Python installed.

2. Install `mono` using your package manager.

On ArchLinux:
```
sudo pacman -Syy mono
```

3. Go to `/CONFIGURE_FOR_LINUX/` and run `setup`
```
./setup
```

4. Run `eirc`
```
./eirc
```

 * MacOS:

1. Install Mono from this site: https://www.mono-project.com/download/stable/#download-mac

2. Run `eIRC.exe` using mono in the console
```
mono eIRC.exe
```
