using System.Security.Cryptography;

Console.WriteLine("\r\n           __                     __       __                                                 \r\n          |  \\                  _|  \\_    |  \\                                                \r\n  ______  | $$____    ______   /   $$ \\  _| $$_    __   __   __   ______    ______    ______  \r\n /      \\ | $$    \\  /      \\ |  $$$$$$\\|   $$ \\  |  \\ |  \\ |  \\ |      \\  /      \\  /      \\ \r\n|  $$$$$$\\| $$$$$$$\\|  $$$$$$\\| $$___\\$$ \\$$$$$$  | $$ | $$ | $$  \\$$$$$$\\|  $$$$$$\\|  $$$$$$\\\r\n| $$  | $$| $$  | $$| $$  | $$ \\$$    \\   | $$ __ | $$ | $$ | $$ /      $$| $$   \\$$| $$    $$\r\n| $$__| $$| $$  | $$| $$__/ $$ _\\$$$$$$\\  | $$|  \\| $$_/ $$_/ $$|  $$$$$$$| $$      | $$$$$$$$\r\n \\$$    $$| $$  | $$ \\$$    $$|  \\__/ $$   \\$$  $$ \\$$   $$   $$ \\$$    $$| $$       \\$$     \\\r\n _\\$$$$$$$ \\$$   \\$$  \\$$$$$$  \\$$    $$    \\$$$$   \\$$$$$\\$$$$   \\$$$$$$$ \\$$        \\$$$$$$$\r\n|  \\__| $$                      \\$$$$$$                                                       \r\n \\$$    $$                        \\$$                                                         \r\n  \\$$$$$$                                                                                     \r\n");

Thread.Sleep(1000);

byte[] key = new byte[32]; // 32 bytes to AES-256
byte[] iv = new byte[16];  // 16 bytes to IV

using (var rng = new RNGCryptoServiceProvider()) {
    rng.GetBytes(key);
    rng.GetBytes(iv);
}

string keyBase64 = Convert.ToBase64String(key);
string ivBase64 = Convert.ToBase64String(iv);

Console.WriteLine($"[+] Key: {keyBase64}");
Console.WriteLine($"[+] IV: {ivBase64}");

Console.WriteLine("\n[>] Press any key to close.");
Console.ReadKey();
Environment.Exit(0);