using SimpleHashing;

public class HashingUtils
{
    private static string[] _algorithms = new string[]
    {
        "Haval/Haval_3_128",
        "Haval/Haval_3_160",
        "Haval/Haval_3_192",
        "Haval/Haval_3_224",
        "Haval/Haval_3_256",
        "Haval/Haval_4_128",
        "Haval/Haval_4_160",
        "Haval/Haval_4_192",
        "Haval/Haval_4_224",
        "Haval/Haval_4_256",
        "Haval/Haval_5_128",
        "Haval/Haval_5_160",
        "Haval/Haval_5_192",
        "Haval/Haval_5_224",
        "Haval/Haval_5_256",
        "MD/MD2",
        "MD/MD4",
        "MD/MD5",
        "Other/Adler32",
        "Other/Gost",
        "Other/HAS160",
        "Other/Whirlpool",
        "Other/ZaHash",
        "Other/ZeHesh",
        "RIPEMD/RIPEMD128",
        "RIPEMD/RIPEMD160",
        "RIPEMD/RIPEMD256",
        "RIPEMD/RIPEMD320",
        "SHA/SHA0",
        "SHA/SHA1",
        "SHA/SHA224",
        "SHA/SHA256",
        "SHA/SHA384",
        "SHA/SHA512",
        "Snefru/Snefru_4_128",
        "Snefru/Snefru_4_256",
        "Snefru/Snefru_8_128",
        "Snefru/Snefru_8_256",
        "Tiger/Tiger2",
        "Tiger/Tiger_3_192",
        "Tiger/Tiger_4_192",
        "CRC/CRC32/CRC32A",
        "CRC/CRC32/CRC32B",
        "CRC/CRC64/CRC64A",
        "CRC/CRC64/CRC64B",
        "Fastest/HalfSip",
        "Fastest/Komi",
        "Fastest/Mir",
        "Fastest/Mum",
        "Fastest/Mx3",
        "Fastest/Pengy",
        "Other/Hash32/AP",
        "Other/Hash32/Bernstein",
        "Other/Hash32/Bernstein1",
        "Other/Hash32/BKDR",
        "Other/Hash32/DEK",
        "Other/Hash32/DJB",
        "Other/Hash32/DotNet",
        "Other/Hash32/ELF",
        "Other/Hash32/FNV",
        "Other/Hash32/FNV1A",
        "Other/Hash32/Jenkins3",
        "Other/Hash32/JS",
        "Other/Hash32/Murmur2",
        "Other/Hash32/OneAtTime",
        "Other/Hash32/PJW",
        "Other/Hash32/Rotating",
        "Other/Hash32/RS",
        "Other/Hash32/SDBM",
        "Other/Hash32/ShiftAndXor",
        "Other/Hash32/SuperFast",
        "Other/Hash64/FNV",
        "Other/Hash64/FNV1A",
        "Other/Hash64/Murmur2",
        "SHA3/Blake/Blake224",
        "SHA3/Blake/Blake256",
        "SHA3/Blake/Blake384",
        "SHA3/Blake/Blake512",
        "SHA3/BlueMidnightWish/BlueMidnightWish224",
        "SHA3/BlueMidnightWish/BlueMidnightWish256",
        "SHA3/BlueMidnightWish/BlueMidnightWish384",
        "SHA3/BlueMidnightWish/BlueMidnightWish512",
        "SHA3/CubeHash/CubeHash224",
        "SHA3/CubeHash/CubeHash256",
        "SHA3/CubeHash/CubeHash384",
        "SHA3/CubeHash/CubeHash512",
        "SHA3/Echo/Echo224",
        "SHA3/Echo/Echo256",
        "SHA3/Echo/Echo384",
        "SHA3/Echo/Echo512",
        "SHA3/Fugue/Fugue224",
        "SHA3/Fugue/Fugue256",
        "SHA3/Fugue/Fugue384",
        "SHA3/Fugue/Fugue512",
        "SHA3/Groestl/Groestl224",
        "SHA3/Groestl/Groestl256",
        "SHA3/Groestl/Groestl384",
        "SHA3/Groestl/Groestl512",
        "SHA3/Hamsi/Hamsi224",
        "SHA3/Hamsi/Hamsi256",
        "SHA3/Hamsi/Hasmi384",
        "SHA3/Hamsi/Hasmi512",
        "SHA3/JH/JH224",
        "SHA3/JH/JH256",
        "SHA3/JH/JH384",
        "SHA3/JH/JH512",
        "SHA3/Keccak/Keccak224",
        "SHA3/Keccak/Keccak256",
        "SHA3/Keccak/Keccak384",
        "SHA3/Keccak/Keccak512",
        "SHA3/Luffa/Luffa224",
        "SHA3/Luffa/Luffa256",
        "SHA3/Luffa/Luffa384",
        "SHA3/Luffa/Luffa512",
        "SHA3/Shabal/Shabal224",
        "SHA3/Shabal/Shabal256",
        "SHA3/Shabal/Shabal384",
        "SHA3/Shabal/Shabal512",
        "SHA3/SHAvite3/SHAvite3_224",
        "SHA3/SHAvite3/SHAvite3_256",
        "SHA3/SHAvite3/SHAvite3_384",
        "SHA3/SHAvite3/SHAvite3_512",
        "SHA3/SIMD/SIMD224",
        "SHA3/SIMD/SIMD256",
        "SHA3/SIMD/SIMD384",
        "SHA3/SIMD/SIMD512",
        "SHA3/Skein/Skein224",
        "SHA3/Skein/Skein256",
        "SHA3/Skein/Skein384",
        "SHA3/Skein/Skein512",
        "Fastest/Farm/Farm128",
        "Fastest/Farm/Farm32",
        "Fastest/Farm/Farm64",
        "Fastest/Fast/Fast32",
        "Fastest/Fast/Fast64",
        "Fastest/FastPositive/FastPositiveV0",
        "Fastest/FastPositive/FastPositiveV1",
        "Fastest/FastPositive/FastPositiveV2",
        "Fastest/Highway/Highway128",
        "Fastest/Highway/Highway256",
        "Fastest/Highway/Highway64",
        "Fastest/MetroV1/MetroV1_128",
        "Fastest/MetroV1/MetroV1_64",
        "Fastest/MetroV2/MetroV2_128",
        "Fastest/MetroV2/MetroV2_64",
        "Fastest/Sip/SipV1",
        "Fastest/Sip/SipV2",
        "Fastest/Spooky/Spooky128",
        "Fastest/Spooky/Spooky32",
        "Fastest/Spooky/Spooky64",
        "Fastest/Wy/Wy32",
        "Fastest/Wy/Wy64",
        "Fastest/Xx/Xx32",
        "Fastest/Xx/Xx64"
    };

    public static string[] GetAlgorithms()
    {
        return _algorithms;
    }

    public static bool IsAlgorithmValid(string algorithm)
    {
        foreach (string alg in _algorithms)
        {
            if (algorithm.ToLower().Equals(alg.ToLower()))
            {
                return true;
            }
        }

        return false;
    }

    public static string GetHash(byte[] data, string algorithm)
    {
        switch (algorithm)
        {

            case "Haval/Haval_3_128":
                return GetHash(SimpleHashing.Haval.Haval_3_128.ComputeHash(data));
            case "Haval/Haval_3_160":
                return GetHash(SimpleHashing.Haval.Haval_3_160.ComputeHash(data));
            case "Haval/Haval_3_192":
                return GetHash(SimpleHashing.Haval.Haval_3_192.ComputeHash(data));
            case "Haval/Haval_3_224":
                return GetHash(SimpleHashing.Haval.Haval_3_224.ComputeHash(data));
            case "Haval/Haval_3_256":
                return GetHash(SimpleHashing.Haval.Haval_3_256.ComputeHash(data));
            case "Haval/Haval_4_128":
                return GetHash(SimpleHashing.Haval.Haval_4_128.ComputeHash(data));
            case "Haval/Haval_4_160":
                return GetHash(SimpleHashing.Haval.Haval_4_160.ComputeHash(data));
            case "Haval/Haval_4_192":
                return GetHash(SimpleHashing.Haval.Haval_4_192.ComputeHash(data));
            case "Haval/Haval_4_224":
                return GetHash(SimpleHashing.Haval.Haval_4_224.ComputeHash(data));
            case "Haval/Haval_4_256":
                return GetHash(SimpleHashing.Haval.Haval_4_256.ComputeHash(data));
            case "Haval/Haval_5_128":
                return GetHash(SimpleHashing.Haval.Haval_5_128.ComputeHash(data));
            case "Haval/Haval_5_160":
                return GetHash(SimpleHashing.Haval.Haval_5_160.ComputeHash(data));
            case "Haval/Haval_5_192":
                return GetHash(SimpleHashing.Haval.Haval_5_192.ComputeHash(data));
            case "Haval/Haval_5_224":
                return GetHash(SimpleHashing.Haval.Haval_5_224.ComputeHash(data));
            case "Haval/Haval_5_256":
                return GetHash(SimpleHashing.Haval.Haval_5_256.ComputeHash(data));
            case "MD/MD2":
                return GetHash(SimpleHashing.MD.MD2.ComputeHash(data));
            case "MD/MD4":
                return GetHash(SimpleHashing.MD.MD4.ComputeHash(data));
            case "MD/MD5":
                return GetHash(SimpleHashing.MD.MD5.ComputeHash(data));
            case "Other/Adler32":
                return GetHash(SimpleHashing.Other.Adler32.ComputeHash(data));
            case "Other/Gost":
                return GetHash(SimpleHashing.Other.Gost.ComputeHash(data));
            case "Other/HAS160":
                return GetHash(SimpleHashing.Other.HAS160.ComputeHash(data));
            case "Other/Whirlpool":
                return GetHash(SimpleHashing.Other.Whirlpool.ComputeHash(data));
            case "Other/ZaHash":
                return GetHash(SimpleHashing.Other.ZaHash.ComputeHash(data));
            case "Other/ZeHesh":
                return GetHash(SimpleHashing.Other.ZeHesh.ComputeHash(data));
            case "RIPEMD/RIPEMD128":
                return GetHash(SimpleHashing.RIPEMD.RIPEMD128.ComputeHash(data));
            case "RIPEMD/RIPEMD160":
                return GetHash(SimpleHashing.RIPEMD.RIPEMD160.ComputeHash(data));
            case "RIPEMD/RIPEMD256":
                return GetHash(SimpleHashing.RIPEMD.RIPEMD256.ComputeHash(data));
            case "RIPEMD/RIPEMD320":
                return GetHash(SimpleHashing.RIPEMD.RIPEMD320.ComputeHash(data));
            case "SHA/SHA0":
                return GetHash(SimpleHashing.SHA.SHA0.ComputeHash(data));
            case "SHA/SHA1":
                return GetHash(SimpleHashing.SHA.SHA1.ComputeHash(data));
            case "SHA/SHA224":
                return GetHash(SimpleHashing.SHA.SHA224.ComputeHash(data));
            case "SHA/SHA256":
                return GetHash(SimpleHashing.SHA.SHA256.ComputeHash(data));
            case "SHA/SHA384":
                return GetHash(SimpleHashing.SHA.SHA384.ComputeHash(data));
            case "SHA/SHA512":
                return GetHash(SimpleHashing.SHA.SHA512.ComputeHash(data));
            case "Snefru/Snefru_4_128":
                return GetHash(SimpleHashing.Snefru.Snefru_4_128.ComputeHash(data));
            case "Snefru/Snefru_4_256":
                return GetHash(SimpleHashing.Snefru.Snefru_4_256.ComputeHash(data));
            case "Snefru/Snefru_8_128":
                return GetHash(SimpleHashing.Snefru.Snefru_8_128.ComputeHash(data));
            case "Snefru/Snefru_8_256":
                return GetHash(SimpleHashing.Snefru.Snefru_8_256.ComputeHash(data));
            case "Tiger/Tiger2":
                return GetHash(SimpleHashing.Tiger.Tiger2.ComputeHash(data));
            case "Tiger/Tiger_3_192":
                return GetHash(SimpleHashing.Tiger.Tiger_3_192.ComputeHash(data));
            case "Tiger/Tiger_4_192":
                return GetHash(SimpleHashing.Tiger.Tiger_4_192.ComputeHash(data));
            case "CRC/CRC32/CRC32A":
                return GetHash(SimpleHashing.CRC.CRC32.CRC32A.ComputeHash(data));
            case "CRC/CRC32/CRC32B":
                return GetHash(SimpleHashing.CRC.CRC32.CRC32B.ComputeHash(data));
            case "CRC/CRC64/CRC64A":
                return GetHash(SimpleHashing.CRC.CRC64.CRC64A.ComputeHash(data));
            case "CRC/CRC64/CRC64B":
                return GetHash(SimpleHashing.CRC.CRC64.CRC64B.ComputeHash(data));
            case "Fastest/HalfSip":
                return GetHash(SimpleHashing.Fastest.HalfSip.ComputeHash(data));
            case "Fastest/Komi":
                return GetHash(SimpleHashing.Fastest.Komi.ComputeHash(data));
            case "Fastest/Mir":
                return GetHash(SimpleHashing.Fastest.Mir.ComputeHash(data));
            case "Fastest/Mum":
                return GetHash(SimpleHashing.Fastest.Mum.ComputeHash(data));
            case "Fastest/Mx3":
                return GetHash(SimpleHashing.Fastest.Mx3.ComputeHash(data));
            case "Fastest/Pengy":
                return GetHash(SimpleHashing.Fastest.Pengy.ComputeHash(data));
            case "Other/Hash32/AP":
                return GetHash(SimpleHashing.Other.Hash32.AP.ComputeHash(data));
            case "Other/Hash32/Bernstein":
                return GetHash(SimpleHashing.Other.Hash32.Bernstein.ComputeHash(data));
            case "Other/Hash32/Bernstein1":
                return GetHash(SimpleHashing.Other.Hash32.Bernstein1.ComputeHash(data));
            case "Other/Hash32/BKDR":
                return GetHash(SimpleHashing.Other.Hash32.BKDR.ComputeHash(data));
            case "Other/Hash32/DEK":
                return GetHash(SimpleHashing.Other.Hash32.DEK.ComputeHash(data));
            case "Other/Hash32/DJB":
                return GetHash(SimpleHashing.Other.Hash32.DJB.ComputeHash(data));
            case "Other/Hash32/DotNet":
                return GetHash(SimpleHashing.Other.Hash32.DotNet.ComputeHash(data));
            case "Other/Hash32/ELF":
                return GetHash(SimpleHashing.Other.Hash32.ELF.ComputeHash(data));
            case "Other/Hash32/FNV":
                return GetHash(SimpleHashing.Other.Hash32.FNV.ComputeHash(data));
            case "Other/Hash32/FNV1A":
                return GetHash(SimpleHashing.Other.Hash32.FNV1A.ComputeHash(data));
            case "Other/Hash32/Jenkins3":
                return GetHash(SimpleHashing.Other.Hash32.Jenkins3.ComputeHash(data));
            case "Other/Hash32/JS":
                return GetHash(SimpleHashing.Other.Hash32.JS.ComputeHash(data));
            case "Other/Hash32/Murmur2":
                return GetHash(SimpleHashing.Other.Hash32.Murmur2.ComputeHash(data));
            case "Other/Hash32/OneAtTime":
                return GetHash(SimpleHashing.Other.Hash32.OneAtTime.ComputeHash(data));
            case "Other/Hash32/PJW":
                return GetHash(SimpleHashing.Other.Hash32.PJW.ComputeHash(data));
            case "Other/Hash32/Rotating":
                return GetHash(SimpleHashing.Other.Hash32.Rotating.ComputeHash(data));
            case "Other/Hash32/RS":
                return GetHash(SimpleHashing.Other.Hash32.RS.ComputeHash(data));
            case "Other/Hash32/SDBM":
                return GetHash(SimpleHashing.Other.Hash32.SDBM.ComputeHash(data));
            case "Other/Hash32/ShiftAndXor":
                return GetHash(SimpleHashing.Other.Hash32.ShiftAndXor.ComputeHash(data));
            case "Other/Hash32/SuperFast":
                return GetHash(SimpleHashing.Other.Hash32.SuperFast.ComputeHash(data));
            case "Other/Hash64/FNV":
                return GetHash(SimpleHashing.Other.Hash64.FNV.ComputeHash(data));
            case "Other/Hash64/FNV1A":
                return GetHash(SimpleHashing.Other.Hash64.FNV1A.ComputeHash(data));
            case "Other/Hash64/Murmur2":
                return GetHash(SimpleHashing.Other.Hash64.Murmur2.ComputeHash(data));
            case "SHA3/Blake/Blake224":
                return GetHash(SimpleHashing.SHA3.Blake.Blake224.ComputeHash(data));
            case "SHA3/Blake/Blake256":
                return GetHash(SimpleHashing.SHA3.Blake.Blake256.ComputeHash(data));
            case "SHA3/Blake/Blake384":
                return GetHash(SimpleHashing.SHA3.Blake.Blake384.ComputeHash(data));
            case "SHA3/Blake/Blake512":
                return GetHash(SimpleHashing.SHA3.Blake.Blake512.ComputeHash(data));
            case "SHA3/BlueMidnightWish/BlueMidnightWish224":
                return GetHash(SimpleHashing.SHA3.BlueMidnightWish.BlueMidnightWish224.ComputeHash(data));
            case "SHA3/BlueMidnightWish/BlueMidnightWish256":
                return GetHash(SimpleHashing.SHA3.BlueMidnightWish.BlueMidnightWish256.ComputeHash(data));
            case "SHA3/BlueMidnightWish/BlueMidnightWish384":
                return GetHash(SimpleHashing.SHA3.BlueMidnightWish.BlueMidnightWish384.ComputeHash(data));
            case "SHA3/BlueMidnightWish/BlueMidnightWish512":
                return GetHash(SimpleHashing.SHA3.BlueMidnightWish.BlueMidnightWish512.ComputeHash(data));
            case "SHA3/CubeHash/CubeHash224":
                return GetHash(SimpleHashing.SHA3.CubeHash.CubeHash224.ComputeHash(data));
            case "SHA3/CubeHash/CubeHash256":
                return GetHash(SimpleHashing.SHA3.CubeHash.CubeHash256.ComputeHash(data));
            case "SHA3/CubeHash/CubeHash384":
                return GetHash(SimpleHashing.SHA3.CubeHash.CubeHash384.ComputeHash(data));
            case "SHA3/CubeHash/CubeHash512":
                return GetHash(SimpleHashing.SHA3.CubeHash.CubeHash512.ComputeHash(data));
            case "SHA3/Echo/Echo224":
                return GetHash(SimpleHashing.SHA3.Echo.Echo224.ComputeHash(data));
            case "SHA3/Echo/Echo256":
                return GetHash(SimpleHashing.SHA3.Echo.Echo256.ComputeHash(data));
            case "SHA3/Echo/Echo384":
                return GetHash(SimpleHashing.SHA3.Echo.Echo384.ComputeHash(data));
            case "SHA3/Echo/Echo512":
                return GetHash(SimpleHashing.SHA3.Echo.Echo512.ComputeHash(data));
            case "SHA3/Fugue/Fugue224":
                return GetHash(SimpleHashing.SHA3.Fugue.Fugue224.ComputeHash(data));
            case "SHA3/Fugue/Fugue256":
                return GetHash(SimpleHashing.SHA3.Fugue.Fugue256.ComputeHash(data));
            case "SHA3/Fugue/Fugue384":
                return GetHash(SimpleHashing.SHA3.Fugue.Fugue384.ComputeHash(data));
            case "SHA3/Fugue/Fugue512":
                return GetHash(SimpleHashing.SHA3.Fugue.Fugue512.ComputeHash(data));
            case "SHA3/Groestl/Groestl224":
                return GetHash(SimpleHashing.SHA3.Groestl.Groestl224.ComputeHash(data));
            case "SHA3/Groestl/Groestl256":
                return GetHash(SimpleHashing.SHA3.Groestl.Groestl256.ComputeHash(data));
            case "SHA3/Groestl/Groestl384":
                return GetHash(SimpleHashing.SHA3.Groestl.Groestl384.ComputeHash(data));
            case "SHA3/Groestl/Groestl512":
                return GetHash(SimpleHashing.SHA3.Groestl.Groestl512.ComputeHash(data));
            case "SHA3/Hamsi/Hamsi224":
                return GetHash(SimpleHashing.SHA3.Hamsi.Hamsi224.ComputeHash(data));
            case "SHA3/Hamsi/Hamsi256":
                return GetHash(SimpleHashing.SHA3.Hamsi.Hamsi256.ComputeHash(data));
            case "SHA3/Hamsi/Hasmi384":
                return GetHash(SimpleHashing.SHA3.Hamsi.Hamsi384.ComputeHash(data));
            case "SHA3/Hamsi/Hasmi512":
                return GetHash(SimpleHashing.SHA3.Hamsi.Hamsi512.ComputeHash(data));
            case "SHA3/JH/JH224":
                return GetHash(SimpleHashing.SHA3.JH.JH224.ComputeHash(data));
            case "SHA3/JH/JH256":
                return GetHash(SimpleHashing.SHA3.JH.JH256.ComputeHash(data));
            case "SHA3/JH/JH384":
                return GetHash(SimpleHashing.SHA3.JH.JH384.ComputeHash(data));
            case "SHA3/JH/JH512":
                return GetHash(SimpleHashing.SHA3.JH.JH512.ComputeHash(data));
            case "SHA3/Keccak/Keccak224":
                return GetHash(SimpleHashing.SHA3.Keccak.Keccak224.ComputeHash(data));
            case "SHA3/Keccak/Keccak256":
                return GetHash(SimpleHashing.SHA3.Keccak.Keccak256.ComputeHash(data));
            case "SHA3/Keccak/Keccak384":
                return GetHash(SimpleHashing.SHA3.Keccak.Keccak384.ComputeHash(data));
            case "SHA3/Keccak/Keccak512":
                return GetHash(SimpleHashing.SHA3.Keccak.Keccak512.ComputeHash(data));
            case "SHA3/Luffa/Luffa224":
                return GetHash(SimpleHashing.SHA3.Luffa.Luffa224.ComputeHash(data));
            case "SHA3/Luffa/Luffa256":
                return GetHash(SimpleHashing.SHA3.Luffa.Luffa256.ComputeHash(data));
            case "SHA3/Luffa/Luffa384":
                return GetHash(SimpleHashing.SHA3.Luffa.Luffa384.ComputeHash(data));
            case "SHA3/Luffa/Luffa512":
                return GetHash(SimpleHashing.SHA3.Luffa.Luffa512.ComputeHash(data));
            case "SHA3/Shabal/Shabal224":
                return GetHash(SimpleHashing.SHA3.Shabal.Shabal224.ComputeHash(data));
            case "SHA3/Shabal/Shabal256":
                return GetHash(SimpleHashing.SHA3.Shabal.Shabal256.ComputeHash(data));
            case "SHA3/Shabal/Shabal384":
                return GetHash(SimpleHashing.SHA3.Shabal.Shabal384.ComputeHash(data));
            case "SHA3/Shabal/Shabal512":
                return GetHash(SimpleHashing.SHA3.Shabal.Shabal512.ComputeHash(data));
            case "SHA3/SHAvite3/SHAvite3_224":
                return GetHash(SimpleHashing.SHA3.SHAvite3.SHAvite3_224.ComputeHash(data));
            case "SHA3/SHAvite3/SHAvite3_256":
                return GetHash(SimpleHashing.SHA3.SHAvite3.SHAvite3_256.ComputeHash(data));
            case "SHA3/SHAvite3/SHAvite3_384":
                return GetHash(SimpleHashing.SHA3.SHAvite3.SHAvite3_384.ComputeHash(data));
            case "SHA3/SHAvite3/SHAvite3_512":
                return GetHash(SimpleHashing.SHA3.SHAvite3.SHAvite3_512.ComputeHash(data));
            case "SHA3/SIMD/SIMD224":
                return GetHash(SimpleHashing.SHA3.SIMD.SIMD224.ComputeHash(data));
            case "SHA3/SIMD/SIMD256":
                return GetHash(SimpleHashing.SHA3.SIMD.SIMD256.ComputeHash(data));
            case "SHA3/SIMD/SIMD384":
                return GetHash(SimpleHashing.SHA3.SIMD.SIMD384.ComputeHash(data));
            case "SHA3/SIMD/SIMD512":
                return GetHash(SimpleHashing.SHA3.SIMD.SIMD512.ComputeHash(data));
            case "SHA3/Skein/Skein224":
                return GetHash(SimpleHashing.SHA3.Skein.Skein224.ComputeHash(data));
            case "SHA3/Skein/Skein256":
                return GetHash(SimpleHashing.SHA3.Skein.Skein256.ComputeHash(data));
            case "SHA3/Skein/Skein384":
                return GetHash(SimpleHashing.SHA3.Skein.Skein384.ComputeHash(data));
            case "SHA3/Skein/Skein512":
                return GetHash(SimpleHashing.SHA3.Skein.Skein512.ComputeHash(data));
            case "Fastest/Farm/Farm128":
                return GetHash(SimpleHashing.Fastest.Farm.Farm128.ComputeHash(data));
            case "Fastest/Farm/Farm32":
                return GetHash(SimpleHashing.Fastest.Farm.Farm32.ComputeHash(data));
            case "Fastest/Farm/Farm64":
                return GetHash(SimpleHashing.Fastest.Farm.Farm64.ComputeHash(data));
            case "Fastest/Fast/Fast32":
                return GetHash(SimpleHashing.Fastest.Fast.Fast32.ComputeHash(data));
            case "Fastest/Fast/Fast64":
                return GetHash(SimpleHashing.Fastest.Fast.Fast64.ComputeHash(data));
            case "Fastest/FastPositive/FastPositiveV0":
                return GetHash(SimpleHashing.Fastest.FastPositive.FastPositiveV0.ComputeHash(data));
            case "Fastest/FastPositive/FastPositiveV1":
                return GetHash(SimpleHashing.Fastest.FastPositive.FastPositiveV1.ComputeHash(data));
            case "Fastest/FastPositive/FastPositiveV2":
                return GetHash(SimpleHashing.Fastest.FastPositive.FastPositiveV2.ComputeHash(data));
            case "Fastest/Highway/Highway128":
                return GetHash(SimpleHashing.Fastest.Highway.Highway128.ComputeHash(data));
            case "Fastest/Highway/Highway256":
                return GetHash(SimpleHashing.Fastest.Highway.Highway256.ComputeHash(data));
            case "Fastest/Highway/Highway64":
                return GetHash(SimpleHashing.Fastest.Highway.Highway64.ComputeHash(data));
            case "Fastest/MetroV1/MetroV1_128":
                return GetHash(SimpleHashing.Fastest.MetroV1.MetroV1_128.ComputeHash(data));
            case "Fastest/MetroV1/MetroV1_64":
                return GetHash(SimpleHashing.Fastest.MetroV1.MetroV1_64.ComputeHash(data));
            case "Fastest/MetroV2/MetroV2_128":
                return GetHash(SimpleHashing.Fastest.MetroV1.MetroV2_128.ComputeHash(data));
            case "Fastest/MetroV2/MetroV2_64":
                return GetHash(SimpleHashing.Fastest.MetroV1.MetroV2_64.ComputeHash(data));
            case "Fastest/Sip/SipV1":
                return GetHash(SimpleHashing.Fastest.Sip.SipV1.ComputeHash(data));
            case "Fastest/Sip/SipV2":
                return GetHash(SimpleHashing.Fastest.Sip.SipV2.ComputeHash(data));
            case "Fastest/Spooky/Spooky128":
                return GetHash(SimpleHashing.Fastest.Spooky.Spooky128.ComputeHash(data));
            case "Fastest/Spooky/Spooky32":
                return GetHash(SimpleHashing.Fastest.Spooky.Spooky32.ComputeHash(data));
            case "Fastest/Spooky/Spooky64":
                return GetHash(SimpleHashing.Fastest.Spooky.Spook64.ComputeHash(data));
            case "Fastest/Wy/Wy32":
                return GetHash(SimpleHashing.Fastest.Wy.Wy32.ComputeHash(data));
            case "Fastest/Wy/Wy64":
                return GetHash(SimpleHashing.Fastest.Wy.Wy64.ComputeHash(data));
            case "Fastest/Xx/Xx32":
                return GetHash(SimpleHashing.Fastest.Xx.Xx32.ComputeHash(data));
            case "Fastest/Xx/Xx64":
                return GetHash(SimpleHashing.Fastest.Xx.Xx64.ComputeHash(data));
        }

        return string.Empty;
    }

    private static string GetHash(byte[] data)
    {
        return BitConverter.ToString(data).Replace("-", String.Empty).ToLower();
    }
}