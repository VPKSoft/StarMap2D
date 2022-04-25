#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

namespace StarMap2D.Calculations.StaticData.IAUNamedStars;

/// <summary>
/// A class containing stars named by the IAU.
/// </summary>
/// <remarks>
/// The data is Copyright © 2022 IAU, taken @ 2022/02/10 13:47:00 UTC.
/// See: https://www.iau.org/public/themes/naming_stars/
/// </remarks>
// ReSharper disable once InconsistentNaming
public class IAUNamed
{
    /// <summary>
    /// Gets the list of IAU-named stars.
    /// </summary>
    public static readonly IAUNamed[] NamedStars = {
        new()
        {
            Name = "Absolutno", Designation = "XO-5", Id = "_", Constellation = "Lyn", No = "_", VMag = 12.13,
            RightAscension = 116.716506, Declination = 39.094572,
        },
        new()
        {
            Name = "Alasia", Designation = "HD 168746", Id = "_", Constellation = "Ser", No = "_", VMag = 7.95,
            RightAscension = 275.457428, Declination = -11.922682,
        },
        new()
        {
            Name = "Amadioha", Designation = "HD 43197", Id = "_", Constellation = "CMa", No = "_", VMag = 8.98,
            RightAscension = 93.398590, Declination = -29.897264,
        },
        new()
        {
            Name = "Amansinaya", Designation = "WASP-34", Id = "_", Constellation = "Crt", No = "_", VMag = 10.30,
            RightAscension = 165.399575, Declination = -23.860662,
        },
        new()
        {
            Name = "Anadolu", Designation = "WASP-52", Id = "_", Constellation = "Peg", No = "_", VMag = 12.20,
            RightAscension = 348.494823, Declination = 8.761270,
        },
        new()
        {
            Name = "Aniara", Designation = "HD 102956", Id = "_", Constellation = "UMa", No = "_", VMag = 7.86,
            RightAscension = 177.843796, Declination = 57.640734,
        },
        new()
        {
            Name = "Arcalís", Designation = "HD 131496", Id = "_", Constellation = "Boo", No = "_", VMag = 7.80,
            RightAscension = 223.345951, Declination = 18.235409,
        },
        new()
        {
            Name = "Atakoraka", Designation = "WASP-64", Id = "_", Constellation = "CMa", No = "_", VMag = 12.69,
            RightAscension = 101.115022, Declination = -32.858383,
        },
        new()
        {
            Name = "Axólotl", Designation = "HD 224693", Id = "_", Constellation = "Cet", No = "_", VMag = 8.23,
            RightAscension = 359.974298, Declination = -22.428116,
        },
        new()
        {
            Name = "Ayeyarwady", Designation = "HD 18742", Id = "_", Constellation = "Eri", No = "_", VMag = 7.81,
            RightAscension = 45.044402, Declination = -20.802604,
        },
        new()
        {
            Name = "Baekdu", Designation = "HD 133086", Id = "8", Constellation = "UMi", No = "_", VMag = 6.83,
            RightAscension = 224.201473, Declination = 74.900923,
        },
        new()
        {
            Name = "Bélénos", Designation = "HD 8574", Id = "_", Constellation = "Psc", No = "_", VMag = 7.12,
            RightAscension = 021.302148, Declination = 28.566695,
        },
        new()
        {
            Name = "Belel", Designation = "HD 181342", Id = "_", Constellation = "Sgr", No = "_", VMag = 7.55,
            RightAscension = 290.267627, Declination = -23.619570,
        },
        new()
        {
            Name = "Berehynia", Designation = "HAT-P-15", Id = "_", Constellation = "Per", No = "_", VMag = 12.02,
            RightAscension = 066.248062, Declination = 39.460642,
        },
        new()
        {
            Name = "Bibhā", Designation = "HD 86081", Id = "_", Constellation = "Sex", No = "_", VMag = 8.73,
            RightAscension = 149.024661, Declination = -3.808423,
        },
        new()
        {
            Name = "Bosona", Designation = "HD 206610", Id = "_", Constellation = "Aqr", No = "_", VMag = 8.34,
            RightAscension = 325.853751, Declination = -7.408253,
        },
        new()
        {
            Name = "Bubup", Designation = "HD 38283", Id = "_", Constellation = "Men", No = "_", VMag = 6.69,
            RightAscension = 84.258403, Declination = -73.699346,
        },
        new()
        {
            Name = "Buna", Designation = "HD 16175", Id = "_", Constellation = "And", No = "_", VMag = 7.28,
            RightAscension = 39.257963, Declination = 42.062630,
        },
        new()
        {
            Name = "Ceibo", Designation = "HD 63454", Id = "_", Constellation = "Cha", No = "_", VMag = 9.37,
            RightAscension = 114.841057, Declination = -78.278974,
        },
        new()
        {
            Name = "Chaophraya", Designation = "WASP-50", Id = "_", Constellation = "Eri", No = "_", VMag = 11.74,
            RightAscension = 043.688059, Declination = -10.898063,
        },
        new()
        {
            Name = "Chasoň", Designation = "HAT-P-5", Id = "_", Constellation = "Lyr", No = "_", VMag = 11.96,
            RightAscension = 274.405470, Declination = 36.621436,
        },
        new()
        {
            Name = "Chechia", Designation = "HD 192699", Id = "_", Constellation = "Aql", No = "_", VMag = 6.44,
            RightAscension = 304.025017, Declination = 4.580795,
        },
        new()
        {
            Name = "Citadelle", Designation = "HD 1502", Id = "_", Constellation = "Psc", No = "_", VMag = 8.36,
            RightAscension = 4.821110, Declination = 14.054756,
        },
        new()
        {
            Name = "Citalá", Designation = "HD 52265", Id = "_", Constellation = "Mon", No = "_", VMag = 6.29,
            RightAscension = 105.075149, Declination = -5.367161,
        },
        new()
        {
            Name = "Cocibolca", Designation = "HD 4208", Id = "_", Constellation = "Scl", No = "_", VMag = 7.78,
            RightAscension = 11.111045, Declination = -26.515683,
        },
        new()
        {
            Name = "Dingolay", Designation = "HD 96063", Id = "_", Constellation = "Leo", No = "_", VMag = 8.21,
            RightAscension = 166.185228, Declination = -02.513218,
        },
        new()
        {
            Name = "Dìwö", Designation = "WASP-17", Id = "_", Constellation = "Sco", No = "_", VMag = 11.49,
            RightAscension = 239.962287, Declination = -28.061753,
        },
        new()
        {
            Name = "Diya", Designation = "WASP-72", Id = "_", Constellation = "For", No = "_", VMag = 10.97,
            RightAscension = 041.040041, Declination = -30.169045,
        },
        new()
        {
            Name = "Dofida", Designation = "HD 117618", Id = "_", Constellation = "Cen", No = "_", VMag = 7.17,
            RightAscension = 203.106482, Declination = -47.271365,
        },
        new()
        {
            Name = "Dombay", Designation = "HAT-P-3", Id = "_", Constellation = "UMa", No = "_", VMag = 11.52,
            RightAscension = 206.094141, Declination = 48.028668,
        },
        new()
        {
            Name = "Ebla", Designation = "HD 218566", Id = "_", Constellation = "Psc", No = "_", VMag = 8.59,
            RightAscension = 347.294696, Declination = -2.260746,
        },
        new()
        {
            Name = "Emiw", Designation = "HD 7199", Id = "_", Constellation = "Tuc", No = "_", VMag = 8.06,
            RightAscension = 17.696756, Declination = -66.188164,
        },
        new()
        {
            Name = "Felixvarela", Designation = "BD-17 63", Id = "_", Constellation = "Cet", No = "_", VMag = 9.62,
            RightAscension = 7.142942, Declination = -16.226345,
        },
        new()
        {
            Name = "Flegetonte", Designation = "HD 102195", Id = "_", Constellation = "Vir", No = "_", VMag = 8.07,
            RightAscension = 176.426220, Declination = 2.821479,
        },
        new()
        {
            Name = "Formosa", Designation = "HD 100655", Id = "_", Constellation = "Leo", No = "_", VMag = 6.45,
            RightAscension = 173.765637, Declination = 20.441545,
        },
        new()
        {
            Name = "Franz", Designation = "HAT-P-14", Id = "_", Constellation = "Her", No = "_", VMag = 9.86,
            RightAscension = 260.116160, Declination = 38.242197,
        },
        new()
        {
            Name = "Funi", Designation = "HD 109246", Id = "_", Constellation = "Dra", No = "_", VMag = 8.75,
            RightAscension = 188.029952, Declination = 74.489547,
        },
        new()
        {
            Name = "Gakyid", Designation = "HD 73534", Id = "_", Constellation = "Cnc", No = "_", VMag = 8.23,
            RightAscension = 129.815846, Declination = 12.960375,
        },
        new()
        {
            Name = "Gloas", Designation = "WASP-13", Id = "_", Constellation = "Lyn", No = "_", VMag = 10.51,
            RightAscension = 140.102977, Declination = 33.882417,
        },
        new()
        {
            Name = "Gumala", Designation = "HD 179949", Id = "V5652", Constellation = "Sgr", No = "_", VMag = 6.25,
            RightAscension = 288.888459, Declination = -24.179354,
        },
        new()
        {
            Name = "Hoggar", Designation = "HD 28678", Id = "_", Constellation = "Tau", No = "_", VMag = 8.38,
            RightAscension = 67.856059, Declination = 4.575295,
        },
        new()
        {
            Name = "Horna", Designation = "HAT-P-38", Id = "_", Constellation = "Tri", No = "_", VMag = 12.53,
            RightAscension = 035.383251, Declination = 32.246136,
        },
        new()
        {
            Name = "Hunahpú", Designation = "HD 98219", Id = "_", Constellation = "Crt", No = "_", VMag = 8.05,
            RightAscension = 169.448138, Declination = -23.975415,
        },
        new()
        {
            Name = "Hunor", Designation = "HAT-P-2", Id = "_", Constellation = "Her", No = "_", VMag = 8.72,
            RightAscension = 245.151491, Declination = 41.048086,
        },
        new()
        {
            Name = "Illyrian", Designation = "HD 82886", Id = "_", Constellation = "LMi", No = "_", VMag = 7.62,
            RightAscension = 143.938267, Declination = 34.780742,
        },
        new()
        {
            Name = "Inquill", Designation = "HD 156411", Id = "_", Constellation = "Ara", No = "_", VMag = 6.67,
            RightAscension = 259.964168, Declination = -48.549320,
        },
        new()
        {
            Name = "Intan", Designation = "HD 20868", Id = "_", Constellation = "For", No = "_", VMag = 9.92,
            RightAscension = 50.177891, Declination = -33.730104,
        },
        new()
        {
            Name = "Irena", Designation = "WASP-38", Id = "_", Constellation = "Her", No = "_", VMag = 9.41,
            RightAscension = 243.959855, Declination = 10.032579,
        },
        new()
        {
            Name = "Itonda", Designation = "HD 208487", Id = "_", Constellation = "Gru", No = "_", VMag = 7.47,
            RightAscension = 329.332698, Declination = -37.763624,
        },
        new()
        {
            Name = "Kalausi", Designation = "HD 83443", Id = "_", Constellation = "Vel", No = "_", VMag = 8.23,
            RightAscension = 144.299282, Declination = -43.272204,
        },
        new()
        {
            Name = "Kamuy", Designation = "HD 145457", Id = "_", Constellation = "CrB", No = "_", VMag = 6.57,
            RightAscension = 242.516310, Declination = 26.742748,
        },
        new()
        {
            Name = "Karaka", Designation = "HD 137388", Id = "_", Constellation = "Aps", No = "_", VMag = 8.71,
            RightAscension = 233.916337, Declination = -80.204594,
        },
        new()
        {
            Name = "Kaveh", Designation = "HD 175541", Id = "_", Constellation = "Ser", No = "_", VMag = 8.02,
            RightAscension = 283.920350, Declination = 4.265323,
        },
        new()
        {
            Name = "Koeia", Designation = "HIP 12961", Id = "_", Constellation = "Eri", No = "_", VMag = 10.25,
            RightAscension = 041.678695, Declination = -23.086612,
        },
        new()
        {
            Name = "Koit", Designation = "XO-4", Id = "_", Constellation = "Lyn", No = "_", VMag = 10.62,
            RightAscension = 110.388168, Declination = 58.268087,
        },
        new()
        {
            Name = "Lerna", Designation = "HAT-P-42", Id = "_", Constellation = "Hya", No = "_", VMag = 12.15,
            RightAscension = 135.344371, Declination = 6.097227,
        },
        new()
        {
            Name = "Liesma", Designation = "HD 118203", Id = "_", Constellation = "UMa", No = "_", VMag = 8.05,
            RightAscension = 203.510581, Declination = 53.728527,
        },
        new()
        {
            Name = "Lionrock", Designation = "HD 212771", Id = "_", Constellation = "Aqr", No = "_", VMag = 7.60,
            RightAscension = 336.762801, Declination = -17.263656,
        },
        new()
        {
            Name = "Lucilinburhuc", Designation = "HD 45350", Id = "_", Constellation = "Aur", No = "_",
            VMag = 7.89, RightAscension = 97.190463, Declination = 38.962962,
        },
        new()
        {
            Name = "Lusitânia", Designation = "HD 45652", Id = "_", Constellation = "Mon", No = "_", VMag = 8.10,
            RightAscension = 97.304966, Declination = 10.933891,
        },
        new()
        {
            Name = "Macondo", Designation = "HD 93083", Id = "_", Constellation = "Ant", No = "_", VMag = 8.30,
            RightAscension = 161.087146, Declination = -33.577024,
        },
        new()
        {
            Name = "Mago", Designation = "HD 32518", Id = "_", Constellation = "Cam", No = "_", VMag = 6.43,
            RightAscension = 77.403000, Declination = 69.639404,
        },
        new()
        {
            Name = "Mahsati", Designation = "HD 152581", Id = "_", Constellation = "Oph", No = "_", VMag = 8.38,
            RightAscension = 253.431594, Declination = 11.973748,
        },
        new()
        {
            Name = "Malmok", Designation = "WASP-39", Id = "V732", Constellation = "Vir", No = "_", VMag = 11.89,
            RightAscension = 217.326730, Declination = -3.444501,
        },
        new()
        {
            Name = "Márohu", Designation = "WASP-6", Id = "_", Constellation = "Aqr", No = "_", VMag = 12.16,
            RightAscension = 348.157237, Declination = -22.673966,
        },
        new()
        {
            Name = "Mazaalai", Designation = "HAT-P-21", Id = "_", Constellation = "UMa", No = "_", VMag = 11.72,
            RightAscension = 171.274941, Declination = 41.027964,
        },
        new()
        {
            Name = "Moldoveanu", Designation = "XO-1", Id = "_", Constellation = "CrB", No = "_", VMag = 11.28,
            RightAscension = 240.549360, Declination = 28.169561,
        },
        new()
        {
            Name = "Mönch", Designation = "HD 130322", Id = "_", Constellation = "Vir", No = "_", VMag = 8.04,
            RightAscension = 221.886361, Declination = -00.281474,
        },
        new()
        {
            Name = "Montuno", Designation = "WASP-79", Id = "_", Constellation = "Eri", No = "_", VMag = 10.06,
            RightAscension = 066.370903, Declination = -30.600447,
        },
        new()
        {
            Name = "Morava", Designation = "WASP-60", Id = "_", Constellation = "Peg", No = "_", VMag = 12.18,
            RightAscension = 356.666561, Declination = 31.155937,
        },
        new()
        {
            Name = "Moriah", Designation = "HAT-P-23", Id = "_", Constellation = "Del", No = "_", VMag = 12.32,
            RightAscension = 306.123848, Declination = 16.762170,
        },
        new()
        {
            Name = "Mouhoun", Designation = "HD 30856", Id = "_", Constellation = "Eri", No = "_", VMag = 7.91,
            RightAscension = 72.574423, Declination = -24.368843,
        },
        new()
        {
            Name = "Mpingo", Designation = "WASP-71", Id = "_", Constellation = "Cet", No = "_", VMag = 10.70,
            RightAscension = 029.263350, Declination = 0.758855,
        },
        new()
        {
            Name = "Muspelheim", Designation = "HAT-P-29", Id = "_", Constellation = "Per", No = "_", VMag = 11.89,
            RightAscension = 033.131160, Declination = 51.778767,
        },
        new()
        {
            Name = "Naledi", Designation = "WASP-62", Id = "_", Constellation = "Dor", No = "_", VMag = 10.12,
            RightAscension = 087.139974, Declination = -63.988441,
        },
        new()
        {
            Name = "Násti", Designation = "HD 68988", Id = "_", Constellation = "UMa", No = "_", VMag = 8.20,
            RightAscension = 124.592386, Declination = 61.460721,
        },
        new()
        {
            Name = "Natasha", Designation = "HD 85390", Id = "_", Constellation = "Vel", No = "_", VMag = 8.54,
            RightAscension = 147.510404, Declination = -49.790266,
        },
        new()
        {
            Name = "Nenque", Designation = "HD 6434", Id = "_", Constellation = "Phe", No = "_", VMag = 7.72,
            RightAscension = 16.167293, Declination = -39.488218,
        },
        new()
        {
            Name = "Nervia", Designation = "HD 49674", Id = "_", Constellation = "Aur", No = "A", VMag = 8.10,
            RightAscension = 102.877151, Declination = 40.867757,
        },
        new()
        {
            Name = "Nikawiy", Designation = "HD 136418", Id = "_", Constellation = "Boo", No = "_", VMag = 7.88,
            RightAscension = 229.775760, Declination = 41.733206,
        },
        new()
        {
            Name = "Nosaxa", Designation = "HD 48265", Id = "_", Constellation = "Pup", No = "_", VMag = 8.05,
            RightAscension = 100.007196, Declination = -48.541956,
        },
        new()
        {
            Name = "Nushagak", Designation = "HD 17156", Id = "_", Constellation = "Cas", No = "_", VMag = 8.17,
            RightAscension = 42.435361, Declination = 71.753231,
        },
        new()
        {
            Name = "Nyamien", Designation = "WASP-15", Id = "_", Constellation = "Cen", No = "_", VMag = 10.91,
            RightAscension = 208.927967, Declination = -32.159615,
        },
        new()
        {
            Name = "Parumleo", Designation = "WASP-32", Id = "_", Constellation = "Psc", No = "_", VMag = 11.54,
            RightAscension = 003.961699, Declination = 1.200441,
        },
        new()
        {
            Name = "Petra", Designation = "WASP-80", Id = "_", Constellation = "Aql", No = "_", VMag = 11.88,
            RightAscension = 303.167372, Declination = -2.144220,
        },
        new()
        {
            Name = "Phoenicia", Designation = "HD 192263", Id = "V1703", Constellation = "Aql", No = "_",
            VMag = 7.79, RightAscension = 303.499356, Declination = -0.866881,
        },
        new()
        {
            Name = "Pincoya", Designation = "HD 164604", Id = "_", Constellation = "Sgr", No = "_", VMag = 9.66,
            RightAscension = 270.778888, Declination = -28.560655,
        },
        new()
        {
            Name = "Pipoltr", Designation = "TrES-3", Id = "V1434", Constellation = "Her", No = "_", VMag = 12.37,
            RightAscension = 268.029244, Declination = 37.546177,
        },
        new()
        {
            Name = "Poerava", Designation = "HD 221287", Id = "_", Constellation = "Tuc", No = "_", VMag = 7.82,
            RightAscension = 352.834742, Declination = -58.209731,
        },
        new()
        {
            Name = "Rapeto", Designation = "HD 153950", Id = "_", Constellation = "Sco", No = "_", VMag = 7.39,
            RightAscension = 256.128629, Declination = -43.309770,
        },
        new()
        {
            Name = "Rosaliadecastro", Designation = "HD 149143", Id = "_", Constellation = "Oph", No = "_",
            VMag = 7.89, RightAscension = 248.212712, Declination = 2.084828,
        },
        new()
        {
            Name = "Sagarmatha", Designation = "HD 100777", Id = "_", Constellation = "Leo", No = "_", VMag = 8.42,
            RightAscension = 173.964679, Declination = -04.755695,
        },
        new()
        {
            Name = "Sāmaya", Designation = "HD 205739", Id = "_", Constellation = "PsA", No = "_", VMag = 8.56,
            RightAscension = 324.535016, Declination = -31.737484,
        },
        new()
        {
            Name = "Sansuna", Designation = "HAT-P-34", Id = "_", Constellation = "Sge", No = "_", VMag = 10.31,
            RightAscension = 303.195361, Declination = 18.104833,
        },
        new()
        {
            Name = "Shama", Designation = "HD 99109", Id = "_", Constellation = "Leo", No = "_", VMag = 9.10,
            RightAscension = 171.072328, Declination = -1.529073,
        },
        new()
        {
            Name = "Sharjah", Designation = "HIP 79431", Id = "_", Constellation = "Sco", No = "_", VMag = 11.34,
            RightAscension = 243.174084, Declination = -18.875503,
        },
        new()
        {
            Name = "Sika", Designation = "HD 181720", Id = "_", Constellation = "Sgr", No = "_", VMag = 7.84,
            RightAscension = 290.720770, Declination = -32.919053,
        },
        new()
        {
            Name = "Solaris", Designation = "BD+14-4559", Id = "_", Constellation = "Peg", No = "_", VMag = 9.78,
            RightAscension = 318.399959, Declination = 14.689385,
        },
        new()
        {
            Name = "Sterrennacht", Designation = "HAT-P-6", Id = "_", Constellation = "And", No = "_", VMag = 10.54,
            RightAscension = 354.774209, Declination = 42.465973,
        },
        new()
        {
            Name = "Stribor", Designation = "HD 75898", Id = "_", Constellation = "Lyn", No = "_", VMag = 8.03,
            RightAscension = 133.461689, Declination = 33.056812,
        },
        new()
        {
            Name = "Taika", Designation = "HAT-P-40", Id = "_", Constellation = "Lac", No = "_", VMag = 11.35,
            RightAscension = 335.512865, Declination = 45.457366,
        },
        new()
        {
            Name = "Tangra", Designation = "WASP-21", Id = "_", Constellation = "Peg", No = "_", VMag = 11.55,
            RightAscension = 347.492723, Declination = 18.396078,
        },
        new()
        {
            Name = "Tapecue", Designation = "HD 63765", Id = "_", Constellation = "Car", No = "_", VMag = 8.10,
            RightAscension = 116.957168, Declination = -54.264144,
        },
        new()
        {
            Name = "Tevel", Designation = "HAT-P-9", Id = "_", Constellation = "Aur", No = "_", VMag = 12.26,
            RightAscension = 110.168568, Declination = 37.140651,
        },
        new()
        {
            Name = "Timir", Designation = "HD 148427", Id = "_", Constellation = "Oph", No = "_", VMag = 6.89,
            RightAscension = 247.117296, Declination = -13.399636,
        },
        new()
        {
            Name = "Tislit", Designation = "WASP-161", Id = "_", Constellation = "Pup", No = "_", VMag = 10.77,
            RightAscension = 126.337846, Declination = -11.500986,
        },
        new()
        {
            Name = "Tojil", Designation = "WASP-22", Id = "_", Constellation = "Eri", No = "_", VMag = 11.71,
            RightAscension = 052.818029, Declination = -23.819678,
        },
        new()
        {
            Name = "Tuiren", Designation = "HAT-P-36", Id = "_", Constellation = "CVn", No = "_", VMag = 12.25,
            RightAscension = 188.266276, Declination = 44.915333,
        },
        new()
        {
            Name = "Tupã", Designation = "HD 108147", Id = "_", Constellation = "Cru", No = "_", VMag = 6.99,
            RightAscension = 186.442779, Declination = -64.022088,
        },
        new()
        {
            Name = "Tupi", Designation = "HD 23079", Id = "_", Constellation = "Ret", No = "_", VMag = 7.12,
            RightAscension = 54.929567, Declination = -52.915838,
        },
        new()
        {
            Name = "Uklun", Designation = "HD 102117", Id = "_", Constellation = "Cen", No = "_", VMag = 7.47,
            RightAscension = 176.210254, Declination = -58.703710,
        },
        new()
        {
            Name = "Uruk", Designation = "HD 231701", Id = "_", Constellation = "Sge", No = "_", VMag = 8.97,
            RightAscension = 293.017338, Declination = 16.474289,
        },
        new()
        {
            Name = "Xihe", Designation = "HD 173416", Id = "_", Constellation = "Lyr", No = "_", VMag = 6.04,
            RightAscension = 280.900456, Declination = 36.556606,
        },
        new()
        {
            Name = "Gudja", Designation = "HR 5879", Id = "κ", Constellation = "Ser", No = "-", VMag = 4.09,
            RightAscension = 237.184903, Declination = 18.141564,
        },
        new()
        {
            Name = "Guniibuu", Designation = "HR 6402", Id = "36", Constellation = "Oph", No = "A", VMag = 5.07,
            RightAscension = 258.837875, Declination = -26.598892,
        },
        new()
        {
            Name = "Imai", Designation = "HR 4656", Id = "δ", Constellation = "Cru", No = "-", VMag = 2.75,
            RightAscension = 183.786320, Declination = -58.748927,
        },
        new()
        {
            Name = "La Superba", Designation = "HR 4846", Id = "Y", Constellation = "CVn", No = "-", VMag = 5.42,
            RightAscension = 191.282615, Declination = 45.440257,
        },
        new()
        {
            Name = "Paikauhale", Designation = "HR 6165", Id = "τ", Constellation = "Sco", No = "A", VMag = 2.82,
            RightAscension = 248.970637, Declination = -28.216017,
        },
        new()
        {
            Name = "Toliman", Designation = "HR 5460", Id = "α", Constellation = "Cen", No = "B", VMag = 1.35,
            RightAscension = 219.896096, Declination = -60.837528,
        },
        new()
        {
            Name = "Alpherg", Designation = "HR 437", Id = "η", Constellation = "Psc", No = "A", VMag = 3.83,
            RightAscension = 22.870873, Declination = 15.345823,
        },
        new()
        {
            Name = "Alruba", Designation = "HR 6618", Id = "-", Constellation = "Dra", No = "-", VMag = 5.75,
            RightAscension = 265.996568, Declination = 53.801715,
        },
        new()
        {
            Name = "Ashlesha", Designation = "HR 3482", Id = "ε", Constellation = "Hya", No = "A", VMag = 3.49,
            RightAscension = 131.693794, Declination = 6.418809,
        },
        new()
        {
            Name = "Azmidi", Designation = "HR 3045", Id = "ξ", Constellation = "Pup", No = "–", VMag = 3.45,
            RightAscension = 117.323563, Declination = -24.859786,
        },
        new()
        {
            Name = "Bunda", Designation = "HR 8264", Id = "ξ", Constellation = "Aqr", No = "A", VMag = 4.80,
            RightAscension = 324.437956, Declination = -7.854202,
        },
        new()
        {
            Name = "Elgafar", Designation = "HR 5409", Id = "ϕ", Constellation = "Vir", No = "A", VMag = 4.84,
            RightAscension = 217.050575, Declination = -2.227957,
        },
        new()
        {
            Name = "Elkurud", Designation = "HR 2177", Id = "θ", Constellation = "Col", No = "-", VMag = 5.00,
            RightAscension = 91.881801, Declination = -37.252920,
        },
        new()
        {
            Name = "Fawaris", Designation = "HR 7528", Id = "δ", Constellation = "Cyg", No = "A", VMag = 2.90,
            RightAscension = 296.243658, Declination = 45.130810,
        },
        new()
        {
            Name = "Felis", Designation = "HR 3923", Id = "-", Constellation = "Hya", No = "-", VMag = 4.94,
            RightAscension = 148.717528, Declination = -19.009336,
        },
        new()
        {
            Name = "Fumalsamakah", Designation = "HR 8773", Id = "β", Constellation = "Psc", No = "-", VMag = 4.48,
            RightAscension = 345.969225, Declination = 3.820045,
        },
        new()
        {
            Name = "Heze", Designation = "HR 5107", Id = "ζ", Constellation = "Vir", No = "A", VMag = 3.38,
            RightAscension = 203.673300, Declination = -0.595820,
        },
        new()
        {
            Name = "Kraz", Designation = "HR 4786", Id = "β", Constellation = "Crv", No = "-", VMag = 2.65,
            RightAscension = 188.596810, Declination = -23.396759,
        },
        new()
        {
            Name = "Nahn", Designation = "HR 3627", Id = "ξ", Constellation = "Cnc", No = "A", VMag = 5.70,
            RightAscension = 137.339722, Declination = 22.045446,
        },
        new()
        {
            Name = "Okab", Designation = "HR 7235", Id = "ζ", Constellation = "Aql", No = "A", VMag = 2.99,
            RightAscension = 286.352533, Declination = 13.863477,
        },
        new()
        {
            Name = "Piautos", Designation = "HR 3268", Id = "λ", Constellation = "Cnc", No = "-", VMag = 5.92,
            RightAscension = 125.133901, Declination = 24.022311,
        },
        new()
        {
            Name = "Tarf", Designation = "HR 3249", Id = "β", Constellation = "Cnc", No = "A", VMag = 3.53,
            RightAscension = 124.128838, Declination = 9.185544,
        },
        new()
        {
            Name = "Ukdah", Designation = "HR 3845", Id = "ι", Constellation = "Hya", No = "-", VMag = 3.90,
            RightAscension = 144.964008, Declination = -1.142810,
        },
        new()
        {
            Name = "Acamar", Designation = "HR 897", Id = "θ1", Constellation = "Eri", No = "A", VMag = 2.88,
            RightAscension = 44.565311, Declination = -40.304672,
        },
        new()
        {
            Name = "Achernar", Designation = "HR 472", Id = "α", Constellation = "Eri", No = "A", VMag = 0.45,
            RightAscension = 24.428523, Declination = -57.236753,
        },
        new()
        {
            Name = "Achird", Designation = "HR 219", Id = "η", Constellation = "Cas", No = "A", VMag = 3.46,
            RightAscension = 12.276213, Declination = 57.815187,
        },
        new()
        {
            Name = "Acrab", Designation = "HR 5984", Id = "β1", Constellation = "Sco", No = "Aa", VMag = 2.56,
            RightAscension = 241.359300, Declination = -19.805453,
        },
        new()
        {
            Name = "Acrux", Designation = "HR 4730", Id = "α", Constellation = "Cru", No = "Aa", VMag = 1.33,
            RightAscension = 186.649563, Declination = -63.099093,
        },
        new()
        {
            Name = "Acubens", Designation = "HR 3572", Id = "α", Constellation = "Cnc", No = "Aa", VMag = 4.26,
            RightAscension = 134.621740, Declination = 11.857687,
        },
        new()
        {
            Name = "Adhafera", Designation = "HR 4031", Id = "ζ", Constellation = "Leo", No = "Aa", VMag = 3.43,
            RightAscension = 154.172567, Declination = 23.417312,
        },
        new()
        {
            Name = "Adhara", Designation = "HR 2618", Id = "ε", Constellation = "CMa", No = "A", VMag = 1.50,
            RightAscension = 104.656453, Declination = -28.972086,
        },
        new()
        {
            Name = "Adhil", Designation = "HR 390", Id = "ξ", Constellation = "And", No = "-", VMag = 4.87,
            RightAscension = 20.585080, Declination = 45.528778,
        },
        new()
        {
            Name = "Ain", Designation = "HR 1409", Id = "ε", Constellation = "Tau", No = "Aa1", VMag = 3.53,
            RightAscension = 67.154163, Declination = 19.180435,
        },
        new()
        {
            Name = "Ainalrami", Designation = "HR 7116", Id = "ν1", Constellation = "Sgr", No = "A", VMag = 4.86,
            RightAscension = 283.542404, Declination = -22.744840,
        },
        new()
        {
            Name = "Aladfar", Designation = "HR 7298", Id = "η", Constellation = "Lyr", No = "Aa", VMag = 4.43,
            RightAscension = 288.439531, Declination = 39.145970,
        },
        new()
        {
            Name = "Albaldah", Designation = "HR 7264", Id = "π", Constellation = "Sgr", No = "A", VMag = 2.88,
            RightAscension = 287.440971, Declination = -21.023615,
        },
        new()
        {
            Name = "Albali", Designation = "HR 7950", Id = "ε", Constellation = "Aqr", No = "-", VMag = 3.78,
            RightAscension = 311.918969, Declination = -9.495775,
        },
        new()
        {
            Name = "Albireo", Designation = "HR 7417", Id = "β1", Constellation = "Cyg", No = "Aa", VMag = 3.05,
            RightAscension = 292.680351, Declination = 27.959692,
        },
        new()
        {
            Name = "Alchiba", Designation = "HR 4623", Id = "α", Constellation = "Crv", No = "-", VMag = 4.02,
            RightAscension = 182.103402, Declination = -24.728875,
        },
        new()
        {
            Name = "Alcor", Designation = "HR 5062", Id = "80", Constellation = "UMa", No = "Ca", VMag = 3.99,
            RightAscension = 201.306403, Declination = 54.987954,
        },
        new()
        {
            Name = "Alcyone", Designation = "HR 1165", Id = "η", Constellation = "Tau", No = "A", VMag = 2.85,
            RightAscension = 56.871152, Declination = 24.105136,
        },
        new()
        {
            Name = "Aldebaran", Designation = "HR 1457", Id = "α", Constellation = "Tau", No = "-", VMag = 0.87,
            RightAscension = 68.980163, Declination = 16.509302,
        },
        new()
        {
            Name = "Alderamin", Designation = "HR 8162", Id = "α", Constellation = "Cep", No = "-", VMag = 2.45,
            RightAscension = 319.644885, Declination = 62.585574,
        },
        new()
        {
            Name = "Aldhanab", Designation = "HR 8353", Id = "γ", Constellation = "Gru", No = "-", VMag = 3.00,
            RightAscension = 328.482192, Declination = -37.364855,
        },
        new()
        {
            Name = "Aldhibah", Designation = "HR 6396", Id = "ζ", Constellation = "Dra", No = "A", VMag = 3.17,
            RightAscension = 257.196650, Declination = 65.714684,
        },
        new()
        {
            Name = "Aldulfin", Designation = "HR 7852", Id = "ε", Constellation = "Del", No = "-", VMag = 4.03,
            RightAscension = 308.303216, Declination = 11.303261,
        },
        new()
        {
            Name = "Alfirk", Designation = "HR 8238", Id = "β", Constellation = "Cep", No = "Aa", VMag = 3.23,
            RightAscension = 322.164987, Declination = 70.560715,
        },
        new()
        {
            Name = "Algedi", Designation = "HR 7754", Id = "α2", Constellation = "Cap", No = "-", VMag = 3.58,
            RightAscension = 304.513566, Declination = -12.544852,
        },
        new()
        {
            Name = "Algenib", Designation = "HR 39", Id = "γ", Constellation = "Peg", No = "-", VMag = 2.83,
            RightAscension = 3.308963, Declination = 15.183594,
        },
        new()
        {
            Name = "Algieba", Designation = "HR 4057", Id = "γ1", Constellation = "Leo", No = "-", VMag = 2.61,
            RightAscension = 154.993144, Declination = 19.841489,
        },
        new()
        {
            Name = "Algol", Designation = "HR 936", Id = "β", Constellation = "Per", No = "Aa1", VMag = 2.09,
            RightAscension = 47.042215, Declination = 40.955648,
        },
        new()
        {
            Name = "Algorab", Designation = "HR 4757", Id = "δ", Constellation = "Crv", No = "A", VMag = 2.94,
            RightAscension = 187.466063, Declination = -16.515431,
        },
        new()
        {
            Name = "Alhena", Designation = "HR 2421", Id = "γ", Constellation = "Gem", No = "Aa", VMag = 1.93,
            RightAscension = 99.427960, Declination = 16.399280,
        },
        new()
        {
            Name = "Alioth", Designation = "HR 4905", Id = "ε", Constellation = "UMa", No = "A", VMag = 1.76,
            RightAscension = 193.507290, Declination = 55.959823,
        },
        new()
        {
            Name = "Aljanah", Designation = "HR 7949", Id = "ε", Constellation = "Cyg", No = "Aa", VMag = 2.48,
            RightAscension = 311.552843, Declination = 33.970257,
        },
        new()
        {
            Name = "Alkaid", Designation = "HR 5191", Id = "η", Constellation = "UMa", No = "-", VMag = 1.85,
            RightAscension = 206.885157, Declination = 49.313267,
        },
        new()
        {
            Name = "Alkalurops", Designation = "HR 5733", Id = "μ1", Constellation = "Boo", No = "Aa", VMag = 4.31,
            RightAscension = 231.122618, Declination = 37.377169,
        },
        new()
        {
            Name = "Alkaphrah", Designation = "HR 3594", Id = "κ", Constellation = "UMa", No = "A", VMag = 4.16,
            RightAscension = 135.906365, Declination = 47.156525,
        },
        new()
        {
            Name = "Alkarab", Designation = "HR 8905", Id = "υ", Constellation = "Peg", No = "-", VMag = 4.42,
            RightAscension = 351.344931, Declination = 23.404100,
        },
        new()
        {
            Name = "Alkes", Designation = "HR 4287", Id = "α", Constellation = "Crt", No = "-", VMag = 4.08,
            RightAscension = 164.943604, Declination = -18.298783,
        },
        new()
        {
            Name = "Almaaz", Designation = "HR 1605", Id = "ε", Constellation = "Aur", No = "-", VMag = 3.03,
            RightAscension = 75.492219, Declination = 43.823307,
        },
        new()
        {
            Name = "Almach", Designation = "HR 603", Id = "γ", Constellation = "And", No = "A", VMag = 2.10,
            RightAscension = 30.974804, Declination = 42.329725,
        },
        new()
        {
            Name = "Alnair", Designation = "HR 8425", Id = "α", Constellation = "Gru", No = "-", VMag = 1.73,
            RightAscension = 332.058270, Declination = -46.960974,
        },
        new()
        {
            Name = "Alnasl", Designation = "HR 6746", Id = "γ2", Constellation = "Sgr", No = "-", VMag = 2.98,
            RightAscension = 271.452025, Declination = -30.424100,
        },
        new()
        {
            Name = "Alnilam", Designation = "HR 1903", Id = "ε", Constellation = "Ori", No = "-", VMag = 1.69,
            RightAscension = 84.053389, Declination = -1.201919,
        },
        new()
        {
            Name = "Alnitak", Designation = "HR 1948", Id = "ζ", Constellation = "Ori", No = "Aa", VMag = 1.74,
            RightAscension = 85.189694, Declination = -1.942574,
        },
        new()
        {
            Name = "Alniyat", Designation = "HR 6084", Id = "σ", Constellation = "Sco", No = "Aa1", VMag = 2.90,
            RightAscension = 245.297149, Declination = -25.592792,
        },
        new()
        {
            Name = "Alphard", Designation = "HR 3748", Id = "α", Constellation = "Hya", No = "-", VMag = 1.99,
            RightAscension = 141.896847, Declination = -8.658602,
        },
        new()
        {
            Name = "Alphecca", Designation = "HR 5793", Id = "α", Constellation = "CrB", No = "-", VMag = 2.22,
            RightAscension = 233.671950, Declination = 26.714693,
        },
        new()
        {
            Name = "Alpheratz", Designation = "HR 15", Id = "α", Constellation = "And", No = "Aa", VMag = 2.07,
            RightAscension = 2.096916, Declination = 29.090431,
        },
        new()
        {
            Name = "Alrakis", Designation = "HR 6370", Id = "μ", Constellation = "Dra", No = "A", VMag = 5.55,
            RightAscension = 256.333807, Declination = 54.470078,
        },
        new()
        {
            Name = "Alrescha", Designation = "HR 596", Id = "α", Constellation = "Psc", No = "A", VMag = 3.82,
            RightAscension = 30.511772, Declination = 2.763735,
        },
        new()
        {
            Name = "Alsafi", Designation = "HR 7462", Id = "σ", Constellation = "Dra", No = "-", VMag = 4.67,
            RightAscension = 293.089960, Declination = 69.661176,
        },
        new()
        {
            Name = "Alsciaukat", Designation = "HR 3275", Id = "31", Constellation = "Lyn", No = "-", VMag = 4.25,
            RightAscension = 125.708792, Declination = 43.188131,
        },
        new()
        {
            Name = "Alsephina", Designation = "HR 3485", Id = "δ", Constellation = "Vel", No = "Aa", VMag = 1.99,
            RightAscension = 131.175944, Declination = -54.708819,
        },
        new()
        {
            Name = "Alshain", Designation = "HR 7602", Id = "β", Constellation = "Aql", No = "A", VMag = 3.71,
            RightAscension = 298.828304, Declination = 6.406763,
        },
        new()
        {
            Name = "Alshat", Designation = "HR 7773", Id = "ν", Constellation = "Cap", No = "A", VMag = 4.77,
            RightAscension = 305.165898, Declination = -12.759079,
        },
        new()
        {
            Name = "Altair", Designation = "HR 7557", Id = "α", Constellation = "Aql", No = "-", VMag = 0.76,
            RightAscension = 297.695827, Declination = 8.868321,
        },
        new()
        {
            Name = "Altais", Designation = "HR 7310", Id = "δ", Constellation = "Dra", No = "-", VMag = 3.07,
            RightAscension = 288.138750, Declination = 67.661541,
        },
        new()
        {
            Name = "Alterf", Designation = "HR 3773", Id = "λ", Constellation = "Leo", No = "-", VMag = 4.32,
            RightAscension = 142.930115, Declination = 22.967970,
        },
        new()
        {
            Name = "Aludra", Designation = "HR 2827", Id = "η", Constellation = "CMa", No = "-", VMag = 2.45,
            RightAscension = 111.023760, Declination = -29.303106,
        },
        new()
        {
            Name = "Alula Australis", Designation = "HR 4375", Id = "ξ", Constellation = "UMa", No = "Aa",
            VMag = 4.41, RightAscension = 169.545423, Declination = 31.529161,
        },
        new()
        {
            Name = "Alula Borealis", Designation = "HR 4377", Id = "ν", Constellation = "UMa", No = "-",
            VMag = 3.49, RightAscension = 169.619737, Declination = 33.094305,
        },
        new()
        {
            Name = "Alya", Designation = "HR 7141", Id = "θ1", Constellation = "Ser", No = "A", VMag = 4.62,
            RightAscension = 284.054949, Declination = 4.203602,
        },
        new()
        {
            Name = "Alzirr", Designation = "HR 2484", Id = "ξ", Constellation = "Gem", No = "-", VMag = 3.35,
            RightAscension = 101.322351, Declination = 12.895592,
        },
        new()
        {
            Name = "Ancha", Designation = "HR 8499", Id = "θ", Constellation = "Aqr", No = "-", VMag = 4.17,
            RightAscension = 334.208485, Declination = -7.783291,
        },
        new()
        {
            Name = "Angetenar", Designation = "HR 850", Id = "τ2", Constellation = "Eri", No = "-", VMag = 4.76,
            RightAscension = 42.759674, Declination = -21.004018,
        },
        new()
        {
            Name = "Ankaa", Designation = "HR 99", Id = "α", Constellation = "Phe", No = "-", VMag = 2.40,
            RightAscension = 6.570939, Declination = -42.306084,
        },
        new()
        {
            Name = "Anser", Designation = "HR 7405", Id = "α", Constellation = "Vul", No = "-", VMag = 4.44,
            RightAscension = 292.176375, Declination = 24.664903,
        },
        new()
        {
            Name = "Antares", Designation = "HR 6134", Id = "α", Constellation = "Sco", No = "A", VMag = 1.06,
            RightAscension = 247.351915, Declination = -26.432003,
        },
        new()
        {
            Name = "Arcturus", Designation = "HR 5340", Id = "α", Constellation = "Boo", No = "-", VMag = -0.05,
            RightAscension = 213.915300, Declination = 19.182409,
        },
        new()
        {
            Name = "Arkab Posterior", Designation = "HR 7343", Id = "β2", Constellation = "Sgr", No = "-",
            VMag = 4.27, RightAscension = 290.804740, Declination = -44.799779,
        },
        new()
        {
            Name = "Arkab Prior", Designation = "HR 7337", Id = "β1", Constellation = "Sgr", No = "-", VMag = 3.96,
            RightAscension = 290.659551, Declination = -44.458959,
        },
        new()
        {
            Name = "Arneb", Designation = "HR 1865", Id = "α", Constellation = "Lep", No = "A", VMag = 2.58,
            RightAscension = 83.182567, Declination = -17.822289,
        },
        new()
        {
            Name = "Ascella", Designation = "HR 7194", Id = "ζ", Constellation = "Sgr", No = "A", VMag = 2.60,
            RightAscension = 285.653043, Declination = -29.880063,
        },
        new()
        {
            Name = "Asellus Australis", Designation = "HR 3461", Id = "δ", Constellation = "Cnc", No = "Aa",
            VMag = 3.94, RightAscension = 131.171248, Declination = 18.154309,
        },
        new()
        {
            Name = "Asellus Borealis", Designation = "HR 3449", Id = "γ", Constellation = "Cnc", No = "Aa",
            VMag = 4.66, RightAscension = 130.821442, Declination = 21.468501,
        },
        new()
        {
            Name = "Aspidiske", Designation = "HR 3699", Id = "ι", Constellation = "Car", No = "-", VMag = 2.21,
            RightAscension = 139.272529, Declination = -59.275232,
        },
        new()
        {
            Name = "Asterope", Designation = "HR 1151", Id = "21", Constellation = "Tau", No = "A", VMag = 5.76,
            RightAscension = 56.476987, Declination = 24.554512,
        },
        new()
        {
            Name = "Athebyne", Designation = "HR 6132", Id = "η", Constellation = "Dra", No = "A", VMag = 2.73,
            RightAscension = 245.997858, Declination = 61.514214,
        },
        new()
        {
            Name = "Atik", Designation = "HR 1131", Id = "ο", Constellation = "Per", No = "A", VMag = 3.84,
            RightAscension = 56.079720, Declination = 32.288240,
        },
        new()
        {
            Name = "Atlas", Designation = "HR 1178", Id = "27", Constellation = "Tau", No = "Aa1", VMag = 3.62,
            RightAscension = 57.290597, Declination = 24.053415,
        },
        new()
        {
            Name = "Atria", Designation = "HR 6217", Id = "α", Constellation = "TrA", No = "-", VMag = 1.91,
            RightAscension = 252.166229, Declination = -69.027712,
        },
        new()
        {
            Name = "Avior", Designation = "HR 3307", Id = "ε", Constellation = "Car", No = "A", VMag = 1.86,
            RightAscension = 125.628480, Declination = -59.509484,
        },
        new()
        {
            Name = "Azelfafage", Designation = "HR 8301", Id = "π1", Constellation = "Cyg", No = "-", VMag = 4.69,
            RightAscension = 325.523602, Declination = 51.189623,
        },
        new()
        {
            Name = "Azha", Designation = "HR 874", Id = "η", Constellation = "Eri", No = "-", VMag = 3.89,
            RightAscension = 44.106873, Declination = -8.898145,
        },
        new()
        {
            Name = "Barnard's Star", Designation = "GJ 699", Id = "V2500", Constellation = "Oph", No = "-",
            VMag = 9.54, RightAscension = 269.454023, Declination = 4.668288,
        },
        new()
        {
            Name = "Baten Kaitos", Designation = "HR 539", Id = "ζ", Constellation = "Cet", No = "Aa", VMag = 3.74,
            RightAscension = 27.865137, Declination = -10.335044,
        },
        new()
        {
            Name = "Beemim", Designation = "HR 1393", Id = "υ3", Constellation = "Eri", No = "-", VMag = 3.97,
            RightAscension = 66.009239, Declination = -34.016848,
        },
        new()
        {
            Name = "Beid", Designation = "HR 1298", Id = "ο1", Constellation = "Eri", No = "-", VMag = 4.04,
            RightAscension = 62.966415, Declination = -6.837580,
        },
        new()
        {
            Name = "Bellatrix", Designation = "HR 1790", Id = "γ", Constellation = "Ori", No = "-", VMag = 1.64,
            RightAscension = 81.282764, Declination = 6.349703,
        },
        new()
        {
            Name = "Betelgeuse", Designation = "HR 2061", Id = "α", Constellation = "Ori", No = "Aa", VMag = 0.45,
            RightAscension = 88.792939, Declination = 7.407064,
        },
        new()
        {
            Name = "Bharani", Designation = "HR 838", Id = "41", Constellation = "Ari", No = "Aa", VMag = 3.61,
            RightAscension = 42.495972, Declination = 27.260507,
        },
        new()
        {
            Name = "Biham", Designation = "HR 8450", Id = "θ", Constellation = "Peg", No = "-", VMag = 3.52,
            RightAscension = 332.549939, Declination = 6.197863,
        },
        new()
        {
            Name = "Botein", Designation = "HR 951", Id = "δ", Constellation = "Ari", No = "-", VMag = 4.35,
            RightAscension = 47.907356, Declination = 19.726674,
        },
        new()
        {
            Name = "Brachium", Designation = "HR 5603", Id = "σ", Constellation = "Lib", No = "A", VMag = 3.25,
            RightAscension = 226.017567, Declination = -25.281961,
        },
        new()
        {
            Name = "Canopus", Designation = "HR 2326", Id = "α", Constellation = "Car", No = "A", VMag = -0.62,
            RightAscension = 95.987958, Declination = -52.695661,
        },
        new()
        {
            Name = "Capella", Designation = "HR 1708", Id = "α", Constellation = "Aur", No = "Aa", VMag = 0.08,
            RightAscension = 79.172328, Declination = 45.997991,
        },
        new()
        {
            Name = "Caph", Designation = "HR 21", Id = "β", Constellation = "Cas", No = "A", VMag = 2.28,
            RightAscension = 2.294522, Declination = 59.149781,
        },
        new()
        {
            Name = "Castor", Designation = "HR 2891", Id = "α", Constellation = "Gem", No = "Aa", VMag = 1.98,
            RightAscension = 113.649428, Declination = 31.888276,
        },
        new()
        {
            Name = "Castula", Designation = "HR 265", Id = "υ2", Constellation = "Cas", No = "-", VMag = 4.62,
            RightAscension = 14.166271, Declination = 59.181055,
        },
        new()
        {
            Name = "Cebalrai", Designation = "HR 6603", Id = "β", Constellation = "Oph", No = "-", VMag = 2.76,
            RightAscension = 265.868136, Declination = 4.567300,
        },
        new()
        {
            Name = "Celaeno", Designation = "HR 1140", Id = "16", Constellation = "Tau", No = "-", VMag = 5.45,
            RightAscension = 56.200893, Declination = 24.289468,
        },
        new()
        {
            Name = "Cervantes", Designation = "HR 6585", Id = "μ", Constellation = "Ara", No = "-", VMag = 5.15,
            RightAscension = 266.036255, Declination = -51.834051,
        },
        new()
        {
            Name = "Chalawan", Designation = "HR 4277", Id = "47", Constellation = "UMa", No = "-", VMag = 5.03,
            RightAscension = 164.866553, Declination = 40.430256,
        },
        new()
        {
            Name = "Chamukuy", Designation = "HR 1412", Id = "θ2", Constellation = "Tau", No = "Aa", VMag = 3.73,
            RightAscension = 67.165586, Declination = 15.870882,
        },
        new()
        {
            Name = "Chara", Designation = "HR 4785", Id = "β", Constellation = "CVn", No = "Aa", VMag = 4.24,
            RightAscension = 188.435603, Declination = 41.357479,
        },
        new()
        {
            Name = "Chertan", Designation = "HR 4359", Id = "θ", Constellation = "Leo", No = "-", VMag = 3.33,
            RightAscension = 168.560019, Declination = 15.429571,
        },
        new()
        {
            Name = "Copernicus", Designation = "HR 3522", Id = "55", Constellation = "Cnc", No = "A", VMag = 5.95,
            RightAscension = 133.149212, Declination = 28.330820,
        },
        new()
        {
            Name = "Cor Caroli", Designation = "HR 4915", Id = "α2", Constellation = "CVn", No = "Aa", VMag = 2.89,
            RightAscension = 194.006943, Declination = 38.318376,
        },
        new()
        {
            Name = "Cujam", Designation = "HR 6117", Id = "ω", Constellation = "Her", No = "A", VMag = 4.57,
            RightAscension = 246.353979, Declination = 14.033274,
        },
        new()
        {
            Name = "Cursa", Designation = "HR 1666", Id = "β", Constellation = "Eri", No = "-", VMag = 2.78,
            RightAscension = 76.962440, Declination = -5.086446,
        },
        new()
        {
            Name = "Dabih", Designation = "HR 7776", Id = "β1", Constellation = "Cap", No = "Aa", VMag = 3.05,
            RightAscension = 305.252803, Declination = -14.781405,
        },
        new()
        {
            Name = "Dalim", Designation = "HR 963", Id = "α", Constellation = "For", No = "A", VMag = 3.86,
            RightAscension = 48.018864, Declination = -28.987620,
        },
        new()
        {
            Name = "Deneb Algedi", Designation = "HR 8322", Id = "δ", Constellation = "Cap", No = "Aa", VMag = 2.85,
            RightAscension = 326.760184, Declination = -16.127287,
        },
        new()
        {
            Name = "Deneb", Designation = "HR 7924", Id = "α", Constellation = "Cyg", No = "-", VMag = 1.25,
            RightAscension = 310.357980, Declination = 45.280339,
        },
        new()
        {
            Name = "Denebola", Designation = "HR 4534", Id = "β", Constellation = "Leo", No = "-", VMag = 2.14,
            RightAscension = 177.264910, Declination = 14.572058,
        },
        new()
        {
            Name = "Diadem", Designation = "HR 4968", Id = "α", Constellation = "Com", No = "A", VMag = 4.85,
            RightAscension = 197.497029, Declination = 17.529447,
        },
        new()
        {
            Name = "Diphda", Designation = "HR 188", Id = "β", Constellation = "Cet", No = "-", VMag = 2.04,
            RightAscension = 10.897379, Declination = -17.986606,
        },
        new()
        {
            Name = "Dschubba", Designation = "HR 5953", Id = "δ", Constellation = "Sco", No = "A", VMag = 2.29,
            RightAscension = 240.083359, Declination = -22.621710,
        },
        new()
        {
            Name = "Dubhe", Designation = "HR 4301", Id = "α", Constellation = "UMa", No = "A", VMag = 1.81,
            RightAscension = 165.931965, Declination = 61.751035,
        },
        new()
        {
            Name = "Dziban", Designation = "HR 6636", Id = "ψ1", Constellation = "Dra", No = "A", VMag = 4.57,
            RightAscension = 265.484814, Declination = 72.148847,
        },
        new()
        {
            Name = "Edasich", Designation = "HR 5744", Id = "ι", Constellation = "Dra", No = "-", VMag = 3.29,
            RightAscension = 231.232396, Declination = 58.966063,
        },
        new()
        {
            Name = "Electra", Designation = "HR 1142", Id = "17", Constellation = "Tau", No = "-", VMag = 3.72,
            RightAscension = 56.218904, Declination = 24.113336,
        },
        new()
        {
            Name = "Elnath", Designation = "HR 1791", Id = "β", Constellation = "Tau", No = "Aa", VMag = 1.65,
            RightAscension = 81.572971, Declination = 28.607452,
        },
        new()
        {
            Name = "Eltanin", Designation = "HR 6705", Id = "γ", Constellation = "Dra", No = "-", VMag = 2.24,
            RightAscension = 269.151541, Declination = 51.488896,
        },
        new()
        {
            Name = "Enif", Designation = "HR 8308", Id = "ε", Constellation = "Peg", No = "-", VMag = 2.38,
            RightAscension = 326.046484, Declination = 9.875009,
        },
        new()
        {
            Name = "Errai", Designation = "HR 8974", Id = "γ", Constellation = "Cep", No = "Aa", VMag = 3.21,
            RightAscension = 354.836655, Declination = 77.632313,
        },
        new()
        {
            Name = "Fafnir", Designation = "HR 6945", Id = "42", Constellation = "Dra", No = "A", VMag = 4.82,
            RightAscension = 276.496406, Declination = 65.563480,
        },
        new()
        {
            Name = "Fang", Designation = "HR 5944", Id = "π", Constellation = "Sco", No = "Aa", VMag = 2.89,
            RightAscension = 239.712972, Declination = -26.114108,
        },
        new()
        {
            Name = "Fomalhaut", Designation = "HR 8728", Id = "α", Constellation = "PsA", No = "A", VMag = 1.17,
            RightAscension = 344.412693, Declination = -29.622237,
        },
        new()
        {
            Name = "Fulu", Designation = "HR 153", Id = "ζ", Constellation = "Cas", No = "-", VMag = 3.69,
            RightAscension = 9.242851, Declination = 53.896908,
        },
        new()
        {
            Name = "Furud", Designation = "HR 2282", Id = "ζ", Constellation = "CMa", No = "Aa", VMag = 3.02,
            RightAscension = 95.078300, Declination = -30.063367,
        },
        new()
        {
            Name = "Fuyue", Designation = "HR 6630", Id = "-", Constellation = "Sco", No = "-", VMag = 3.19,
            RightAscension = 267.464503, Declination = -37.043305,
        },
        new()
        {
            Name = "Gacrux", Designation = "HR 4763", Id = "γ", Constellation = "Cru", No = "-", VMag = 1.59,
            RightAscension = 187.791498, Declination = -57.113213,
        },
        new()
        {
            Name = "Giausar", Designation = "HR 4434", Id = "λ", Constellation = "Dra", No = "-", VMag = 3.82,
            RightAscension = 172.850920, Declination = 69.331075,
        },
        new()
        {
            Name = "Gienah", Designation = "HR 4662", Id = "γ", Constellation = "Crv", No = "A", VMag = 2.58,
            RightAscension = 183.951543, Declination = -17.541929,
        },
        new()
        {
            Name = "Gomeisa", Designation = "HR 2845", Id = "β", Constellation = "CMi", No = "A", VMag = 2.89,
            RightAscension = 111.787674, Declination = 8.289316,
        },
        new()
        {
            Name = "Grumium", Designation = "HR 6688", Id = "ξ", Constellation = "Dra", No = "A", VMag = 3.73,
            RightAscension = 268.382207, Declination = 56.872646,
        },
        new()
        {
            Name = "Hadar", Designation = "HR 5267", Id = "β", Constellation = "Cen", No = "Aa", VMag = 0.61,
            RightAscension = 210.955856, Declination = -60.373035,
        },
        new()
        {
            Name = "Haedus", Designation = "HR 1641", Id = "η", Constellation = "Aur", No = "-", VMag = 3.18,
            RightAscension = 76.628722, Declination = 41.234476,
        },
        new()
        {
            Name = "Hamal", Designation = "HR 617", Id = "α", Constellation = "Ari", No = "-", VMag = 2.01,
            RightAscension = 31.793357, Declination = 23.462418,
        },
        new()
        {
            Name = "Hassaleh", Designation = "HR 1577", Id = "ι", Constellation = "Aur", No = "-", VMag = 2.69,
            RightAscension = 74.248421, Declination = 33.166100,
        },
        new()
        {
            Name = "Hatysa", Designation = "HR 1899", Id = "ι", Constellation = "Ori", No = "Aa", VMag = 2.80,
            RightAscension = 83.858258, Declination = -05.909901,
        },
        new()
        {
            Name = "Helvetios", Designation = "HR 8729", Id = "51", Constellation = "Peg", No = "-", VMag = 5.49,
            RightAscension = 344.366583, Declination = 20.768831,
        },
        new()
        {
            Name = "Homam", Designation = "HR 8634", Id = "ζ", Constellation = "Peg", No = "A", VMag = 3.41,
            RightAscension = 340.365503, Declination = 10.831363,
        },
        new()
        {
            Name = "Iklil", Designation = "HR 5928", Id = "ρ", Constellation = "Sco", No = "Aa", VMag = 3.87,
            RightAscension = 239.221151, Declination = -29.214073,
        },
        new()
        {
            Name = "Intercrus", Designation = "HR 3743", Id = "-", Constellation = "UMa", No = "-", VMag = 5.41,
            RightAscension = 142.166618, Declination = 45.601482,
        },
        new()
        {
            Name = "Izar", Designation = "HR 5506", Id = "ε", Constellation = "Boo", No = "A", VMag = 2.35,
            RightAscension = 221.246763, Declination = 27.074207,
        },
        new()
        {
            Name = "Jabbah", Designation = "HR 6027", Id = "ν", Constellation = "Sco", No = "Aa", VMag = 4.50,
            RightAscension = 242.998894, Declination = -19.460708,
        },
        new()
        {
            Name = "Jishui", Designation = "HR 2930", Id = "ο", Constellation = "Gem", No = "-", VMag = 4.89,
            RightAscension = 114.791387, Declination = 34.584346,
        },
        new()
        {
            Name = "Kaffaljidhma", Designation = "HR 804", Id = "γ", Constellation = "Cet", No = "A", VMag = 3.56,
            RightAscension = 40.825163, Declination = 3.235816,
        },
        new()
        {
            Name = "Kang", Designation = "HR 5315", Id = "κ", Constellation = "Vir", No = "-", VMag = 4.18,
            RightAscension = 213.223939, Declination = -10.273704,
        },
        new()
        {
            Name = "Kaus Australis", Designation = "HR 6879", Id = "ε", Constellation = "Sgr", No = "A",
            VMag = 1.79, RightAscension = 276.042993, Declination = -34.384616,
        },
        new()
        {
            Name = "Kaus Borealis", Designation = "HR 6913", Id = "λ", Constellation = "Sgr", No = "-", VMag = 2.82,
            RightAscension = 276.992668, Declination = -25.421701,
        },
        new()
        {
            Name = "Kaus Media", Designation = "HR 6859", Id = "δ", Constellation = "Sgr", No = "-", VMag = 2.72,
            RightAscension = 275.248508, Declination = -29.828104,
        },
        new()
        {
            Name = "Keid", Designation = "HR 1325", Id = "ο2", Constellation = "Eri", No = "A", VMag = 4.43,
            RightAscension = 63.817999, Declination = -7.652872,
        },
        new()
        {
            Name = "Khambalia", Designation = "HR 5359", Id = "λ", Constellation = "Vir", No = "A", VMag = 4.52,
            RightAscension = 214.777468, Declination = -13.371096,
        },
        new()
        {
            Name = "Kitalpha", Designation = "HR 8131", Id = "α", Constellation = "Equ", No = "A", VMag = 3.92,
            RightAscension = 318.955949, Declination = 5.247865,
        },
        new()
        {
            Name = "Kochab", Designation = "HR 5563", Id = "β", Constellation = "UMi", No = "-", VMag = 2.07,
            RightAscension = 222.676357, Declination = 74.155504,
        },
        new()
        {
            Name = "Kornephoros", Designation = "HR 6148", Id = "β", Constellation = "Her", No = "Aa", VMag = 2.78,
            RightAscension = 247.554998, Declination = 21.489611,
        },
        new()
        {
            Name = "Kurhah", Designation = "HR 8417", Id = "ξ", Constellation = "Cep", No = "Aa", VMag = 4.26,
            RightAscension = 330.947724, Declination = 64.627971,
        },
        new()
        {
            Name = "Lesath", Designation = "HR 6508", Id = "υ", Constellation = "Sco", No = "-", VMag = 2.70,
            RightAscension = 262.690979, Declination = -37.295813,
        },
        new()
        {
            Name = "Libertas", Designation = "HR 7595", Id = "ξ", Constellation = "Aql", No = "A", VMag = 4.71,
            RightAscension = 298.562008, Declination = 8.461453,
        },
        new()
        {
            Name = "Lich", Designation = "PSR B1257+12", Id = "-", Constellation = "Vir", No = "-",
            VMag = double.NaN, RightAscension = 195.012701, Declination = 12.682417,
        },
        new()
        {
            Name = "Lilii Borea", Designation = "HR 824", Id = "39", Constellation = "Ari", No = "-", VMag = 4.52,
            RightAscension = 41.977256, Declination = 29.247115,
        },
        new()
        {
            Name = "Maasym", Designation = "HR 6526", Id = "λ", Constellation = "Her", No = "-", VMag = 4.41,
            RightAscension = 262.684626, Declination = 26.110645,
        },
        new()
        {
            Name = "Mahasim", Designation = "HR 2095", Id = "θ", Constellation = "Aur", No = "A", VMag = 2.65,
            RightAscension = 89.930292, Declination = 37.212585,
        },
        new()
        {
            Name = "Maia", Designation = "HR 1149", Id = "20", Constellation = "Tau", No = "-", VMag = 3.87,
            RightAscension = 56.456695, Declination = 24.367751,
        },
        new()
        {
            Name = "Marfik", Designation = "HR 6149", Id = "λ", Constellation = "Oph", No = "A", VMag = 3.82,
            RightAscension = 247.728453, Declination = 1.983888,
        },
        new()
        {
            Name = "Markab", Designation = "HR 8781", Id = "α", Constellation = "Peg", No = "-", VMag = 2.49,
            RightAscension = 346.190223, Declination = 15.205267,
        },
        new()
        {
            Name = "Markeb", Designation = "HR 3734", Id = "κ", Constellation = "Vel", No = "-", VMag = 2.47,
            RightAscension = 140.528407, Declination = -55.010667,
        },
        new()
        {
            Name = "Marsic", Designation = "HR 6008", Id = "κ", Constellation = "Her", No = "A", VMag = 5.00,
            RightAscension = 242.018857, Declination = 17.046980,
        },
        new()
        {
            Name = "Matar", Designation = "HR 8650", Id = "η", Constellation = "Peg", No = "Aa", VMag = 2.93,
            RightAscension = 340.750579, Declination = 30.221244,
        },
        new()
        {
            Name = "Mebsuta", Designation = "HR 2473", Id = "ε", Constellation = "Gem", No = "-", VMag = 3.06,
            RightAscension = 100.983026, Declination = 25.131127,
        },
        new()
        {
            Name = "Megrez", Designation = "HR 4660", Id = "δ", Constellation = "UMa", No = "-", VMag = 3.32,
            RightAscension = 183.856503, Declination = 57.032615,
        },
        new()
        {
            Name = "Meissa", Designation = "HR 1879", Id = "λ", Constellation = "Ori", No = "A", VMag = 3.39,
            RightAscension = 83.784486, Declination = 9.934156,
        },
        new()
        {
            Name = "Mekbuda", Designation = "HR 2650", Id = "ζ", Constellation = "Gem", No = "Aa", VMag = 4.01,
            RightAscension = 106.027215, Declination = 20.570295,
        },
        new()
        {
            Name = "Meleph", Designation = "HR 3429", Id = "ε", Constellation = "Cnc", No = "Aa", VMag = 6.29,
            RightAscension = 130.112544, Declination = 19.544809,
        },
        new()
        {
            Name = "Menkalinan", Designation = "HR 2088", Id = "β", Constellation = "Aur", No = "Aa", VMag = 1.90,
            RightAscension = 89.882179, Declination = 44.947433,
        },
        new()
        {
            Name = "Menkar", Designation = "HR 911", Id = "α", Constellation = "Cet", No = "-", VMag = 2.54,
            RightAscension = 45.569885, Declination = 4.089737,
        },
        new()
        {
            Name = "Menkent", Designation = "HR 5288", Id = "θ", Constellation = "Cen", No = "-", VMag = 2.06,
            RightAscension = 211.670617, Declination = -36.369958,
        },
        new()
        {
            Name = "Menkib", Designation = "HR 1228", Id = "ξ", Constellation = "Per", No = "-", VMag = 3.98,
            RightAscension = 59.741253, Declination = 35.791032,
        },
        new()
        {
            Name = "Merak", Designation = "HR 4295", Id = "β", Constellation = "UMa", No = "-", VMag = 2.34,
            RightAscension = 165.460319, Declination = 56.382426,
        },
        new()
        {
            Name = "Merga", Designation = "HR 5533", Id = "38", Constellation = "Boo", No = "-", VMag = 5.76,
            RightAscension = 222.327791, Declination = 46.116206,
        },
        new()
        {
            Name = "Meridiana", Designation = "HR 7254", Id = "α", Constellation = "CrA", No = "-", VMag = 4.11,
            RightAscension = 287.368087, Declination = -37.904473,
        },
        new()
        {
            Name = "Merope", Designation = "HR 1156", Id = "23", Constellation = "Tau", No = "Aa", VMag = 4.14,
            RightAscension = 56.581552, Declination = 23.948348,
        },
        new()
        {
            Name = "Mesarthim", Designation = "HR 546", Id = "γ1", Constellation = "Ari", No = "A", VMag = 4.75,
            RightAscension = 28.382560, Declination = 19.293852,
        },
        new()
        {
            Name = "Miaplacidus", Designation = "HR 3685", Id = "β", Constellation = "Car", No = "-", VMag = 1.67,
            RightAscension = 138.299906, Declination = -69.717208,
        },
        new()
        {
            Name = "Mimosa", Designation = "HR 4853", Id = "β", Constellation = "Cru", No = "-", VMag = 1.25,
            RightAscension = 191.930263, Declination = -59.688764,
        },
        new()
        {
            Name = "Minchir", Designation = "HR 3418", Id = "σ", Constellation = "Hya", No = "-", VMag = 4.45,
            RightAscension = 129.689323, Declination = 3.341436,
        },
        new()
        {
            Name = "Minelauva", Designation = "HR 4910", Id = "δ", Constellation = "Vir", No = "-", VMag = 3.39,
            RightAscension = 193.900869, Declination = 3.397470,
        },
        new()
        {
            Name = "Mintaka", Designation = "HR 1852", Id = "δ", Constellation = "Ori", No = "Aa", VMag = 2.25,
            RightAscension = 83.001667, Declination = -0.299095,
        },
        new()
        {
            Name = "Mira", Designation = "HR 681", Id = "ο", Constellation = "Cet", No = "Aa", VMag = 6.47,
            RightAscension = 34.836617, Declination = -2.977640,
        },
        new()
        {
            Name = "Mirach", Designation = "HR 337", Id = "β", Constellation = "And", No = "-", VMag = 2.07,
            RightAscension = 17.433013, Declination = 35.620557,
        },
        new()
        {
            Name = "Miram", Designation = "HR 834", Id = "η", Constellation = "Per", No = "A", VMag = 3.77,
            RightAscension = 42.674207, Declination = 55.895497,
        },
        new()
        {
            Name = "Mirfak", Designation = "HR 1017", Id = "α", Constellation = "Per", No = "-", VMag = 1.79,
            RightAscension = 51.080709, Declination = 49.861179,
        },
        new()
        {
            Name = "Mirzam", Designation = "HR 2294", Id = "β", Constellation = "CMa", No = "-", VMag = 1.98,
            RightAscension = 95.674939, Declination = -17.955919,
        },
        new()
        {
            Name = "Misam", Designation = "HR 941", Id = "κ", Constellation = "Per", No = "Aa", VMag = 3.79,
            RightAscension = 47.374048, Declination = 44.857541,
        },
        new()
        {
            Name = "Mizar", Designation = "HR 5054", Id = "ζ", Constellation = "UMa", No = "Aa", VMag = 2.23,
            RightAscension = 200.981429, Declination = 54.925362,
        },
        new()
        {
            Name = "Mothallah", Designation = "HR 544", Id = "α", Constellation = "Tri", No = "-", VMag = 3.42,
            RightAscension = 28.270450, Declination = 29.578826,
        },
        new()
        {
            Name = "Muliphein", Designation = "HR 2657", Id = "γ", Constellation = "CMa", No = "-", VMag = 4.11,
            RightAscension = 105.939554, Declination = -15.633286,
        },
        new()
        {
            Name = "Muphrid", Designation = "HR 5235", Id = "η", Constellation = "Boo", No = "Aa", VMag = 2.68,
            RightAscension = 208.671161, Declination = 18.397717,
        },
        new()
        {
            Name = "Muscida", Designation = "HR 3323", Id = "ο", Constellation = "UMa", No = "A", VMag = 3.35,
            RightAscension = 127.566128, Declination = 60.718170,
        },
        new()
        {
            Name = "Musica", Designation = "HR 8030", Id = "18", Constellation = "Del", No = "-", VMag = 5.48,
            RightAscension = 314.608058, Declination = 10.839286,
        },
        new()
        {
            Name = "Naos", Designation = "HR 3165", Id = "ζ", Constellation = "Pup", No = "-", VMag = 2.21,
            RightAscension = 120.896031, Declination = -40.003148,
        },
        new()
        {
            Name = "Nashira", Designation = "HR 8278", Id = "γ", Constellation = "Cap", No = "A", VMag = 3.69,
            RightAscension = 325.022735, Declination = -16.662308,
        },
        new()
        {
            Name = "Nekkar", Designation = "HR 5602", Id = "β", Constellation = "Boo", No = "-", VMag = 3.49,
            RightAscension = 225.486510, Declination = 40.390567,
        },
        new()
        {
            Name = "Nembus", Designation = "HR 464", Id = "51", Constellation = "And", No = "-", VMag = 3.59,
            RightAscension = 24.498154, Declination = 48.628214,
        },
        new()
        {
            Name = "Nihal", Designation = "HR 1829", Id = "β", Constellation = "Lep", No = "A", VMag = 2.81,
            RightAscension = 82.061346, Declination = -20.759441,
        },
        new()
        {
            Name = "Nunki", Designation = "HR 7121", Id = "σ", Constellation = "Sgr", No = "Aa", VMag = 2.05,
            RightAscension = 283.816360, Declination = -26.296724,
        },
        new()
        {
            Name = "Nusakan", Designation = "HR 5747", Id = "β", Constellation = "CrB", No = "A", VMag = 3.66,
            RightAscension = 231.957211, Declination = 29.105699,
        },
        new()
        {
            Name = "Ogma", Designation = "HD 149026", Id = "-", Constellation = "Her", No = "-", VMag = 8.16,
            RightAscension = 247.623409, Declination = 38.347311,
        },
        new()
        {
            Name = "Peacock", Designation = "HR 7790", Id = "α", Constellation = "Pav", No = "Aa", VMag = 1.94,
            RightAscension = 306.411904, Declination = -56.735090,
        },
        new()
        {
            Name = "Phact", Designation = "HR 1956", Id = "α", Constellation = "Col", No = "-", VMag = 2.65,
            RightAscension = 84.912254, Declination = -34.074110,
        },
        new()
        {
            Name = "Phecda", Designation = "HR 4554", Id = "γ", Constellation = "UMa", No = "Aa", VMag = 2.41,
            RightAscension = 178.457679, Declination = 53.694758,
        },
        new()
        {
            Name = "Pherkad", Designation = "HR 5735", Id = "γ", Constellation = "UMi", No = "-", VMag = 3.00,
            RightAscension = 230.182150, Declination = 71.834017,
        },
        new()
        {
            Name = "Pipirima", Designation = "HR 6252", Id = "μ2", Constellation = "Sco", No = "A", VMag = 3.56,
            RightAscension = 253.083939, Declination = -38.017535,
        },
        new()
        {
            Name = "Pleione", Designation = "HR 1180", Id = "28", Constellation = "Tau", No = "Aa", VMag = 5.05,
            RightAscension = 57.296738, Declination = 24.136710,
        },
        new()
        {
            Name = "Polaris Australis", Designation = "HR 7228", Id = "σ", Constellation = "Oct", No = "-",
            VMag = 5.45, RightAscension = 317.195164, Declination = -88.956499,
        },
        new()
        {
            Name = "Polaris", Designation = "HR 424", Id = "α", Constellation = "UMi", No = "Aa", VMag = 1.97,
            RightAscension = 37.954561, Declination = 89.264109,
        },
        new()
        {
            Name = "Polis", Designation = "HR 6812", Id = "μ", Constellation = "Sgr", No = "Aa", VMag = 3.84,
            RightAscension = 273.440870, Declination = -21.058832,
        },
        new()
        {
            Name = "Pollux", Designation = "HR 2990", Id = "β", Constellation = "Gem", No = "-", VMag = 1.16,
            RightAscension = 116.328958, Declination = 28.026199,
        },
        new()
        {
            Name = "Porrima", Designation = "HR 4825", Id = "γ", Constellation = "Vir", No = "A", VMag = 2.74,
            RightAscension = 190.415181, Declination = -1.449373,
        },
        new()
        {
            Name = "Praecipua", Designation = "HR 4247", Id = "46", Constellation = "LMi", No = "-", VMag = 3.79,
            RightAscension = 163.327937, Declination = 34.214872,
        },
        new()
        {
            Name = "Prima Hyadum", Designation = "HR 1346", Id = "γ", Constellation = "Tau", No = "A", VMag = 3.65,
            RightAscension = 64.948349, Declination = 15.627643,
        },
        new()
        {
            Name = "Procyon", Designation = "HR 2943", Id = "α", Constellation = "CMi", No = "A", VMag = 0.40,
            RightAscension = 114.825493, Declination = 5.224993,
        },
        new()
        {
            Name = "Propus", Designation = "HR 2216", Id = "η", Constellation = "Gem", No = "A", VMag = 3.31,
            RightAscension = 93.719405, Declination = 22.506794,
        },
        new()
        {
            Name = "Proxima Centauri", Designation = "GJ 551", Id = "α", Constellation = "Cen", No = "C",
            VMag = 11.01, RightAscension = 217.428953, Declination = -62.679484,
        },
        new()
        {
            Name = "Ran", Designation = "HR 1084", Id = "ε", Constellation = "Eri", No = "-", VMag = 3.73,
            RightAscension = 53.232687, Declination = -9.458259,
        },
        new()
        {
            Name = "Rasalas", Designation = "HR 3905", Id = "μ", Constellation = "Leo", No = "-", VMag = 3.88,
            RightAscension = 148.190903, Declination = 26.006953,
        },
        new()
        {
            Name = "Rasalgethi", Designation = "HR 6406", Id = "α1", Constellation = "Her", No = "Aa", VMag = 3.37,
            RightAscension = 258.661910, Declination = 14.390333,
        },
        new()
        {
            Name = "Rasalhague", Designation = "HR 6556", Id = "α", Constellation = "Oph", No = "A", VMag = 2.08,
            RightAscension = 263.733627, Declination = 12.560035,
        },
        new()
        {
            Name = "Rastaban", Designation = "HR 6536", Id = "β", Constellation = "Dra", No = "A", VMag = 2.79,
            RightAscension = 262.608174, Declination = 52.301389,
        },
        new()
        {
            Name = "Regulus", Designation = "HR 3982", Id = "α", Constellation = "Leo", No = "A", VMag = 1.36,
            RightAscension = 152.092962, Declination = 11.967209,
        },
        new()
        {
            Name = "Revati", Designation = "HR 361", Id = "ζ", Constellation = "Psc", No = "A", VMag = 5.21,
            RightAscension = 18.432864, Declination = 7.575354,
        },
        new()
        {
            Name = "Rigel", Designation = "HR 1713", Id = "β", Constellation = "Ori", No = "A", VMag = 0.18,
            RightAscension = 78.634467, Declination = -8.201638,
        },
        new()
        {
            Name = "Rigil Kentaurus", Designation = "HR 5459", Id = "α", Constellation = "Cen", No = "A",
            VMag = -0.01, RightAscension = 219.902066, Declination = -60.833975,
        },
        new()
        {
            Name = "Rotanev", Designation = "HR 7882", Id = "β", Constellation = "Del", No = "A", VMag = 3.64,
            RightAscension = 309.387235, Declination = 14.595115,
        },
        new()
        {
            Name = "Ruchbah", Designation = "HR 403", Id = "δ", Constellation = "Cas", No = "Aa", VMag = 2.66,
            RightAscension = 21.453964, Declination = 60.235284,
        },
        new()
        {
            Name = "Rukbat", Designation = "HR 7348", Id = "α", Constellation = "Sgr", No = "-", VMag = 3.96,
            RightAscension = 290.971570, Declination = -40.615940,
        },
        new()
        {
            Name = "Sabik", Designation = "HR 6378", Id = "η", Constellation = "Oph", No = "A", VMag = 2.43,
            RightAscension = 257.594529, Declination = -15.724907,
        },
        new()
        {
            Name = "Saclateni", Designation = "HR 1612", Id = "ζ", Constellation = "Aur", No = "A", VMag = 3.69,
            RightAscension = 75.619531, Declination = 41.075839,
        },
        new()
        {
            Name = "Sadachbia", Designation = "HR 8518", Id = "γ", Constellation = "Aqr", No = "Aa", VMag = 3.86,
            RightAscension = 335.414064, Declination = -1.387334,
        },
        new()
        {
            Name = "Sadalbari", Designation = "HR 8684", Id = "μ", Constellation = "Peg", No = "-", VMag = 3.51,
            RightAscension = 342.500809, Declination = 24.601577,
        },
        new()
        {
            Name = "Sadalmelik", Designation = "HR 8414", Id = "α", Constellation = "Aqr", No = "A", VMag = 2.95,
            RightAscension = 331.445983, Declination = -0.319849,
        },
        new()
        {
            Name = "Sadalsuud", Designation = "HR 8232", Id = "β", Constellation = "Aqr", No = "A", VMag = 2.90,
            RightAscension = 322.889715, Declination = -5.571176,
        },
        new()
        {
            Name = "Sadr", Designation = "HR 7796", Id = "γ", Constellation = "Cyg", No = "A", VMag = 2.23,
            RightAscension = 305.557091, Declination = 40.256679,
        },
        new()
        {
            Name = "Saiph", Designation = "HR 2004", Id = "κ", Constellation = "Ori", No = "-", VMag = 2.07,
            RightAscension = 86.939120, Declination = -9.669605,
        },
        new()
        {
            Name = "Salm", Designation = "HR 8880", Id = "τ", Constellation = "Peg", No = "-", VMag = 4.58,
            RightAscension = 350.159341, Declination = 23.740336,
        },
        new()
        {
            Name = "Sargas", Designation = "HR 6553", Id = "θ", Constellation = "Sco", No = "A", VMag = 1.86,
            RightAscension = 264.329711, Declination = -42.997824,
        },
        new()
        {
            Name = "Sarin", Designation = "HR 6410", Id = "δ", Constellation = "Her", No = "Aa", VMag = 3.12,
            RightAscension = 258.757963, Declination = 24.839204,
        },
        new()
        {
            Name = "Sceptrum", Designation = "HR 1481", Id = "53", Constellation = "Eri", No = "A", VMag = 4.02,
            RightAscension = 69.545104, Declination = -14.304017,
        },
        new()
        {
            Name = "Scheat", Designation = "HR 8775", Id = "β", Constellation = "Peg", No = "-", VMag = 2.44,
            RightAscension = 345.943572, Declination = 28.082785,
        },
        new()
        {
            Name = "Schedar", Designation = "HR 168", Id = "α", Constellation = "Cas", No = "-", VMag = 2.24,
            RightAscension = 10.126838, Declination = 56.537331,
        },
        new()
        {
            Name = "Secunda Hyadum", Designation = "HR 1373", Id = "δ", Constellation = "Tau", No = "Aa",
            VMag = 3.78, RightAscension = 65.733719, Declination = 17.542514,
        },
        new()
        {
            Name = "Segin", Designation = "HR 0542", Id = "ε", Constellation = "Cas", No = "-", VMag = 3.35,
            RightAscension = 28.598857, Declination = 63.670101,
        },
        new()
        {
            Name = "Seginus", Designation = "HR 5435", Id = "γ", Constellation = "Boo", No = "Aa", VMag = 3.04,
            RightAscension = 218.019466, Declination = 38.308251,
        },
        new()
        {
            Name = "Sham", Designation = "HR 7479", Id = "α", Constellation = "Sge", No = "-", VMag = 4.39,
            RightAscension = 295.024133, Declination = 18.013891,
        },
        new()
        {
            Name = "Shaula", Designation = "HR 6527", Id = "λ", Constellation = "Sco", No = "Aa", VMag = 1.62,
            RightAscension = 263.402167, Declination = -37.103824,
        },
        new()
        {
            Name = "Sheliak", Designation = "HR 7106", Id = "β", Constellation = "Lyr", No = "Aa1", VMag = 3.52,
            RightAscension = 282.519978, Declination = 33.362668,
        },
        new()
        {
            Name = "Sheratan", Designation = "HR 553", Id = "β", Constellation = "Ari", No = "A", VMag = 2.64,
            RightAscension = 28.660046, Declination = 20.808031,
        },
        new()
        {
            Name = "Sirius", Designation = "HR 2491", Id = "α", Constellation = "CMa", No = "A", VMag = -1.44,
            RightAscension = 101.287155, Declination = -16.716116,
        },
        new()
        {
            Name = "Situla", Designation = "HR 8610", Id = "κ", Constellation = "Aqr", No = "A", VMag = 5.04,
            RightAscension = 339.439084, Declination = -4.228056,
        },
        new()
        {
            Name = "Skat", Designation = "HR 8709", Id = "δ", Constellation = "Aqr", No = "A", VMag = 3.27,
            RightAscension = 343.662556, Declination = -15.820827,
        },
        new()
        {
            Name = "Spica", Designation = "HR 5056", Id = "α", Constellation = "Vir", No = "Aa", VMag = 0.98,
            RightAscension = 201.298247, Declination = -11.161319,
        },
        new()
        {
            Name = "Sualocin", Designation = "HR 7906", Id = "α", Constellation = "Del", No = "Aa", VMag = 3.77,
            RightAscension = 309.909530, Declination = 15.912073,
        },
        new()
        {
            Name = "Subra", Designation = "HR 3852", Id = "ο", Constellation = "Leo", No = "Aa", VMag = 3.52,
            RightAscension = 145.287640, Declination = 9.892308,
        },
        new()
        {
            Name = "Suhail", Designation = "HR 3634", Id = "λ", Constellation = "Vel", No = "-", VMag = 2.23,
            RightAscension = 136.998993, Declination = -43.432589,
        },
        new()
        {
            Name = "Sulafat", Designation = "HR 7178", Id = "γ", Constellation = "Lyr", No = "-", VMag = 3.25,
            RightAscension = 284.735928, Declination = 32.689557,
        },
        new()
        {
            Name = "Syrma", Designation = "HR 5338", Id = "ι", Constellation = "Vir", No = "-", VMag = 4.07,
            RightAscension = 214.003623, Declination = -6.000545,
        },
        new()
        {
            Name = "Tabit", Designation = "HR 1543", Id = "π3", Constellation = "Ori", No = "-", VMag = 3.19,
            RightAscension = 72.460045, Declination = 6.961275,
        },
        new()
        {
            Name = "Taiyangshou", Designation = "HR 4518", Id = "χ", Constellation = "UMa", No = "-", VMag = 3.69,
            RightAscension = 176.512559, Declination = 47.779406,
        },
        new()
        {
            Name = "Taiyi", Designation = "HR 4916", Id = "8", Constellation = "Dra", No = "-", VMag = 5.23,
            RightAscension = 193.868951, Declination = 65.438474,
        },
        new()
        {
            Name = "Talitha", Designation = "HR 3569", Id = "ι", Constellation = "UMa", No = "Aa", VMag = 3.12,
            RightAscension = 134.801890, Declination = 48.041826,
        },
        new()
        {
            Name = "Tania Australis", Designation = "HR 4069", Id = "μ", Constellation = "UMa", No = "A",
            VMag = 3.06, RightAscension = 155.582250, Declination = 41.499519,
        },
        new()
        {
            Name = "Tania Borealis", Designation = "HR 4033", Id = "λ", Constellation = "UMa", No = "A",
            VMag = 3.45, RightAscension = 154.274095, Declination = 42.914356,
        },
        new()
        {
            Name = "Tarazed", Designation = "HR 7525", Id = "γ", Constellation = "Aql", No = "-", VMag = 2.72,
            RightAscension = 296.564915, Declination = 10.613262,
        },
        new()
        {
            Name = "Taygeta", Designation = "HR 1145", Id = "19", Constellation = "Tau", No = "Aa", VMag = 4.30,
            RightAscension = 56.302063, Declination = 24.467270,
        },
        new()
        {
            Name = "Tegmine", Designation = "HR 3208", Id = "ζ1", Constellation = "Cnc", No = "A", VMag = 4.67,
            RightAscension = 123.053160, Declination = 17.647821,
        },
        new()
        {
            Name = "Tejat", Designation = "HR 2286", Id = "μ", Constellation = "Gem", No = "Aa", VMag = 2.87,
            RightAscension = 95.740112, Declination = 22.513583,
        },
        new()
        {
            Name = "Terebellum", Designation = "HR 7597", Id = "ω", Constellation = "Sgr", No = "A", VMag = 4.70,
            RightAscension = 298.959838, Declination = -26.299534,
        },
        new()
        {
            Name = "Theemin", Designation = "HR 1464", Id = "υ2", Constellation = "Eri", No = "-", VMag = 3.81,
            RightAscension = 68.887660, Declination = -30.562341,
        },
        new()
        {
            Name = "Thuban", Designation = "HR 5291", Id = "α", Constellation = "Dra", No = "A", VMag = 3.67,
            RightAscension = 211.097291, Declination = 64.375851,
        },
        new()
        {
            Name = "Tiaki", Designation = "HR 8636", Id = "β", Constellation = "Gru", No = "-", VMag = 2.12,
            RightAscension = 340.666876, Declination = -46.884576,
        },
        new()
        {
            Name = "Tianguan", Designation = "HR 1910", Id = "ζ", Constellation = "Tau", No = "A", VMag = 2.97,
            RightAscension = 84.411189, Declination = 21.142544,
        },
        new()
        {
            Name = "Tianyi", Designation = "HR 4863", Id = "7", Constellation = "Dra", No = "-", VMag = 5.43,
            RightAscension = 191.893099, Declination = 66.790305,
        },
        new()
        {
            Name = "Titawin", Designation = "HR 458", Id = "υ", Constellation = "And", No = "A", VMag = 4.09,
            RightAscension = 24.199342, Declination = 41.405457,
        },
        new()
        {
            Name = "Tonatiuh", Designation = "HR 4609", Id = "-", Constellation = "Cam", No = "-", VMag = 5.80,
            RightAscension = 181.312995, Declination = 76.905735,
        },
        new()
        {
            Name = "Torcular", Designation = "HR 510", Id = "ο", Constellation = "Psc", No = "A", VMag = 4.29,
            RightAscension = 026.348466, Declination = 9.157737,
        },
        new()
        {
            Name = "Tureis", Designation = "HR 3185", Id = "ρ", Constellation = "Pup", No = "A", VMag = 2.83,
            RightAscension = 121.886037, Declination = -24.304324,
        },
        new()
        {
            Name = "Unukalhai", Designation = "HR 5854", Id = "α", Constellation = "Ser", No = "-", VMag = 2.63,
            RightAscension = 236.066976, Declination = 6.425629,
        },
        new()
        {
            Name = "Unurgunite", Designation = "HR 2646", Id = "σ", Constellation = "CMa", No = "-", VMag = 3.49,
            RightAscension = 105.429782, Declination = -27.934830,
        },
        new()
        {
            Name = "Vega", Designation = "HR 7001", Id = "α", Constellation = "Lyr", No = "-", VMag = 0.03,
            RightAscension = 279.234735, Declination = 38.783689,
        },
        new()
        {
            Name = "Veritate", Designation = "HR 8930", Id = "14", Constellation = "And", No = "A", VMag = 5.22,
            RightAscension = 352.822556, Declination = 39.236197,
        },
        new()
        {
            Name = "Vindemiatrix", Designation = "HR 4932", Id = "ε", Constellation = "Vir", No = "-", VMag = 2.85,
            RightAscension = 195.544157, Declination = 10.959149,
        },
        new()
        {
            Name = "Wasat", Designation = "HR 2777", Id = "δ", Constellation = "Gem", No = "Aa", VMag = 3.50,
            RightAscension = 110.030749, Declination = 21.982316,
        },
        new()
        {
            Name = "Wazn", Designation = "HR 2040", Id = "β", Constellation = "Col", No = "-", VMag = 3.12,
            RightAscension = 87.739968, Declination = -35.768310,
        },
        new()
        {
            Name = "Wezen", Designation = "HR 2693", Id = "δ", Constellation = "CMa", No = "Aa", VMag = 1.83,
            RightAscension = 107.097850, Declination = -26.393200,
        },
        new()
        {
            Name = "Xamidimura", Designation = "HR 6247", Id = "μ1", Constellation = "Sco", No = "Aa", VMag = 3.00,
            RightAscension = 252.967630, Declination = -38.047380,
        },
        new()
        {
            Name = "Xuange", Designation = "HR 5351", Id = "λ", Constellation = "Boo", No = "-", VMag = 4.18,
            RightAscension = 214.095912, Declination = 46.088306,
        },
        new()
        {
            Name = "Yed Posterior", Designation = "HR 6075", Id = "ε", Constellation = "Oph", No = "-", VMag = 3.23,
            RightAscension = 244.580374, Declination = -4.692510,
        },
        new()
        {
            Name = "Yed Prior", Designation = "HR 6056", Id = "δ", Constellation = "Oph", No = "-", VMag = 2.73,
            RightAscension = 243.586411, Declination = -3.694323,
        },
        new()
        {
            Name = "Yildun", Designation = "HR 6789", Id = "δ", Constellation = "UMi", No = "-", VMag = 4.35,
            RightAscension = 263.054126, Declination = 86.586462,
        },
        new()
        {
            Name = "Zaniah", Designation = "HR 4689", Id = "η", Constellation = "Vir", No = "Aa", VMag = 3.89,
            RightAscension = 184.976476, Declination = -0.666793,
        },
        new()
        {
            Name = "Zaurak", Designation = "HR 1231", Id = "γ", Constellation = "Eri", No = "-", VMag = 2.97,
            RightAscension = 59.507360, Declination = -13.508516,
        },
        new()
        {
            Name = "Zavijava", Designation = "HR 4540", Id = "β", Constellation = "Vir", No = "-", VMag = 3.59,
            RightAscension = 177.673826, Declination = 1.764717,
        },
        new()
        {
            Name = "Zhang", Designation = "HR 3903", Id = "υ1", Constellation = "Hya", No = "A", VMag = 4.11,
            RightAscension = 147.869558, Declination = -14.846603,
        },
        new()
        {
            Name = "Zibal", Designation = "HR 984", Id = "ζ", Constellation = "Eri", No = "Aa", VMag = 4.80,
            RightAscension = 48.958436, Declination = -8.819731,
        },
        new()
        {
            Name = "Zosma", Designation = "HR 4357", Id = "δ", Constellation = "Leo", No = "-", VMag = 2.56,
            RightAscension = 168.527089, Declination = 20.523718,
        },
        new()
        {
            Name = "Zubenelgenubi", Designation = "HR 5531", Id = "α2", Constellation = "Lib", No = "Aa",
            VMag = 2.75, RightAscension = 222.719638, Declination = -16.041777,
        },
        new()
        {
            Name = "Zubenelhakrabi", Designation = "HR 5787", Id = "γ", Constellation = "Lib", No = "A",
            VMag = 3.91, RightAscension = 233.881578, Declination = -14.789536,
        },
        new()
        {
            Name = "Zubeneschamali", Designation = "HR 5685", Id = "β", Constellation = "Lib", No = "-",
            VMag = 2.61, RightAscension = 229.251724, Declination = -9.382914,
        },
        new()
        {
            Name = "Larawag", Designation = "HR 6241", Id = "ε", Constellation = "Sco", No = "-", VMag = 2.29,
            RightAscension = 252.540878, Declination = -34.293232,
        },
        new()
        {
            Name = "Ginan", Designation = "HR 4700", Id = "ε", Constellation = "Cru", No = "-", VMag = 3.59,
            RightAscension = 185.340039, Declination = -60.401147,
        },
        new()
        {
            Name = "Wurren", Designation = "HR 338", Id = "ζ", Constellation = "Phe", No = "Aa", VMag = 4.02,
            RightAscension = 17.096173, Declination = -55.245758,
        },
    };

    /// <summary>
    /// Gets or sets the IAU name of the star.
    /// </summary>
    /// <value>The IAU name.</value>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the designation of the star.
    /// </summary>
    /// <value>The star designation.</value>
    public string Designation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the identifier of the star.
    /// </summary>
    /// <value>The star identifier.</value>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the constellation identifier the star belongs to.
    /// </summary>
    /// <value>The star constellation.</value>
    public string Constellation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the # number of the star.
    /// </summary>
    /// <value>The star number.</value>
    public string No { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the visual magnitude of the star.
    /// </summary>
    /// <value>The star visual magnitude.</value>
    public double VMag { get; set; }

    /// <summary>
    /// Gets or sets the right ascension of the star.
    /// </summary>
    /// <value>The star right ascension.</value>
    public double RightAscension { get; set; }

    /// <summary>
    /// Gets or sets the declination of the star.
    /// </summary>
    /// <value>The star declination.</value>
    public double Declination { get; set; }
}
