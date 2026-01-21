//total beli
decimal pembelian (decimal harga, int jumlah)
{
    decimal result = harga * jumlah;
    return result;
}

//pajak
decimal pajak (decimal pembelian, decimal pajak = 0.11m)
{
    decimal result = pembelian * pajak;
    return result;
}
