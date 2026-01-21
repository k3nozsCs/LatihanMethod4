int harga, jumlah;
decimal totalBeli, totalPajak, totalBayar;

//total beli
decimal pembelian (int hrgitm, int jmlitm)
{
    return hrgitm * jmlitm;
}

//pajak
decimal pajak (decimal ttlbeli, decimal pajak = 0.11m)
{
    return ttlbeli * pajak;
}

//input
Console.WriteLine("-Hitung Pajak-\n");

Console.Write("Jumlah Item : ");
jumlah = int.Parse(Console.ReadLine());

Console.Write("Harga Item : Rp.");
harga = int.Parse(Console.ReadLine());

//hitung
totalBeli = pembelian(harga, jumlah);
totalPajak = pajak(totalBeli);
totalBayar = totalBeli + totalPajak;

//output
Console.WriteLine($"Total yang Harus DIbayarkan : Rp.{totalBayar.ToString("N0")}");