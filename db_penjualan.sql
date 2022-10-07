-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Bulan Mei 2022 pada 09.15
-- Versi server: 10.4.19-MariaDB
-- Versi PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penjualan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `kode_barang` varchar(6) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `satuan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`kode_barang`, `nama_barang`, `harga`, `jumlah`, `satuan`) VALUES
('B00001', 'Baju', 80000, 15, 'pcs'),
('B00002', 'Celana', 120000, 13, 'pcs'),
('B00003', 'Jaket', 150000, 23, 'pcs'),
('B00004', 'Topi', 30000, 24, 'pcs');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id_detail` int(6) NOT NULL,
  `transaksi_id` varchar(6) NOT NULL,
  `barang_kode` varchar(6) NOT NULL,
  `harga_jual` int(6) NOT NULL,
  `jumlah_jual` int(6) NOT NULL,
  `sub_total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id_detail`, `transaksi_id`, `barang_kode`, `harga_jual`, `jumlah_jual`, `sub_total`) VALUES
(1, 'T00001', 'B00001', 80000, 2, 160000),
(2, 'T00002', 'B00002', 120000, 2, 240000),
(3, 'T00003', 'B00002', 120000, 3, 360000),
(8, 'T00004', 'B00001', 80000, 1, 80000),
(9, 'T00004', 'B00002', 120000, 2, 240000),
(10, 'T00004', 'B00003', 150000, 1, 150000),
(11, 'T00005', 'B00002', 120000, 2, 240000),
(12, 'T00005', 'B00001', 80000, 2, 160000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `pelanggan`
--

CREATE TABLE `pelanggan` (
  `kode_pelanggan` varchar(6) NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `no_hp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pelanggan`
--

INSERT INTO `pelanggan` (`kode_pelanggan`, `nama_pelanggan`, `alamat`, `no_hp`) VALUES
('P00001', 'Harry', 'Jl. M. Said', '082211445566'),
('P00002', 'Ronald', 'Jl. Revolusi', '081133998855'),
('P00003', 'Hermione', 'Jl. Teuku Umar', '00332211558'),
('P00004', 'Dumbledore', 'Jl. Tengkawang', '081122669988'),
('P00005', 'Snape', 'Jl. Siradj Salman', '082211556633');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `kode_transaksi` varchar(6) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `jam_transaksi` time NOT NULL,
  `pelanggan_kode` varchar(6) NOT NULL,
  `user_kode` varchar(6) NOT NULL,
  `item_terjual` int(6) NOT NULL,
  `total_jual` float NOT NULL,
  `dibayar` float NOT NULL,
  `kembali` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`kode_transaksi`, `tgl_transaksi`, `jam_transaksi`, `pelanggan_kode`, `user_kode`, `item_terjual`, `total_jual`, `dibayar`, `kembali`) VALUES
('T00001', '2022-04-12', '09:45:37', 'P00001', 'ADM001', 2, 200000, 200000, 0),
('T00002', '2022-04-06', '10:45:37', 'P00002', 'OPT001', 3, 280000, 300000, 20000),
('T00003', '2022-04-22', '12:31:23', 'P00001', 'OPT001', 4, 440000, 500000, 60000),
('T00004', '2022-04-26', '09:31:47', 'P00003', 'OPT001', 4, 470000, 500000, 30000),
('T00005', '2022-04-26', '09:56:33', 'P00002', 'OPT001', 4, 400000, 500000, 100000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `kodeadmin` varchar(6) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `level` enum('admin','operator') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`kodeadmin`, `nama`, `password`, `level`) VALUES
('ADM001', 'diahws', '112233', 'admin'),
('ADM002', 'dw', '123321', 'admin'),
('OPT001', 'dws', '123456', 'operator'),
('OPT002', 'ws', '123123', 'operator');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`kode_barang`);

--
-- Indeks untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id_detail`),
  ADD KEY `transaksi_id` (`transaksi_id`),
  ADD KEY `barang_kode` (`barang_kode`);

--
-- Indeks untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`kode_pelanggan`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`kode_transaksi`),
  ADD KEY `pelanggan_kode` (`pelanggan_kode`),
  ADD KEY `user_kode` (`user_kode`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`kodeadmin`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id_detail` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD CONSTRAINT `detail_transaksi_ibfk_1` FOREIGN KEY (`barang_kode`) REFERENCES `barang` (`kode_barang`),
  ADD CONSTRAINT `detail_transaksi_ibfk_2` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`kode_transaksi`);

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`pelanggan_kode`) REFERENCES `pelanggan` (`kode_pelanggan`),
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`user_kode`) REFERENCES `user` (`kodeadmin`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
