V/70A               Nearby Stars, Preliminary 3rd Version  (Gliese+ 1991)
================================================================================
Preliminary Version of the Third Catalogue of Nearby Stars
     GLIESE W., JAHREISS H.
    <Astron. Rechen-Institut, Heidelberg (1991)>
================================================================================
ADC_Keywords: Stars, nearby

Description:
    The present version of the CNS3 contains all known stars within
    25 parsecs of the Sun. It depends mainly on a preliminary version
    (Spring 1989) of the new General Catalogue of Trigonometric
    Parallaxes (YPC) prepared by Dr. William F. van Altena (Yale
    University).

    The catalogue contains every star with trigonometric parallax
    greater than or equal to 0.0390 arcsec, even though it may be
    evident from photometry or for other reasons that the star has a
    larger distance. For red dwarf stars, new color-magnitude
    calibrations for broad-band colors were carried out and applied.
    For white dwarfs, the recipes of McCook and Sion were applied
    (=1985ApJS...65..603M). Stroemgren photometry was used (not yet
    systematically) for early-type stars and for late dwarfs, the
    latter supplied by E. H. Olsen from Copenhagen Observatory
    (private communication).

    Contrary to the CNS2 (Gliese 1969) trigonometric parallaxes
    and photometric or spectroscopic parallaxes were not combined.
    The resulting parallax in the present version is always the
    trigonometric parallax -- if the relative error of the
    trigonometric parallax is smaller than 14 percent. The resulting
    parallax is the photometric or spectroscopic parallax only if no
    trigonometric parallax is available or if the standard error of
    the trigonometric parallax is considerably larger.

Nomenclature Note:
    All new nearby stars have not been numbered, and only "NN" appears in
    the column "Name". There are therefore problems to designate these new
    stars, as e.g. in Reference =1994ApJS...93..287W . It is recommended
    for such stars to use one of the alternate designations from columns
    "Giclas", "LHS", "OtherName" or "Remarks".
    NOTE ADDED IN DECEMBER 1997: However, the usage found in the
    literature led to add a number for these "NN" stars,
    starting from 3001 (for star #2), 3002 (for star #4), etc,
    and ending with NN 4388.

File Summary:
--------------------------------------------------------------------------------
 File Name   Lrecl    Records    Explanations
--------------------------------------------------------------------------------
ReadMe          80          .    This file
catalog.dat    257       3803    The Catalogue
--------------------------------------------------------------------------------

See also:
    III/198 : Palomar/MSU nearby star spectroscopic survey  (Hawley+ 1997)

Byte-by-byte Description of file: catalog.dat
--------------------------------------------------------------------------------
   Bytes Format  Units   Label    Explanations
--------------------------------------------------------------------------------
   1-  8  A8     ---     Name    *Identifier ; see remarks.
   9- 10  A2     ---     Comp     Components (A,B,C,... )
      11  A1     ---     DistRel *[pqsx] Reliability of the distance
  13- 14  I2     h       RAh      ? Right Ascension B1950 (hours)
  16- 17  I2     min     RAm      ? Right Ascension B1950 (minutes)
  19- 20  I2     s       RAs      ? Right Ascension B1950 (seconds)
      22  A1     ---     DE-      Declination B1950 (sign)
  23- 24  I2     deg     DEd      ? Declination B1950 (degrees)
  26- 29  F4.1   arcmin  DEm      ? Declination B1950 (minutes)
  31- 36  F6.3 arcsec/yr pm       ? Total proper motion
      37  A1     ---   u_pm       Uncertainty flag (:) on pm
  38- 42  F5.1   deg     pmPA     ? Direction angle of proper motion
  44- 49  F6.1   km/s    RV       ? Radial velocity
  51- 53  A3     ---   n_RV      *Remark on RV
  55- 66  A12    ---     Sp       Spectral type or color class
      67  A1     ---   r_Sp      *Selected sources
  68- 73  F6.2   mag     Vmag     Apparent magnitude
      74  A1     ---   r_Vmag    *Note on origin of magnitude
      75  A1     ---   n_Vmag     [J] joint magnitude
  76- 80  F5.2   mag     B-V      ? color
      81  A1     ---   r_B-V     *Note on origin of magnitude
      82  A1     ---   n_B-V     *Joint color
  83- 87  F5.2   mag     U-B      ? color
      88  A1     ---   r_U-B     *Note on origin of magnitude
      89  A1     ---   n_U-B     *Joint color
  90- 94  F5.2   mag     R-I      ? color
      95  A1     ---   r_R-I     *Note on origin of magnitude
      96  A1     ---   n_R-I     *Joint color
  97-102  F6.1   mas     trplx    ? Trigonometric parallax
 103-107  F5.1   mas   e_trplx    ? Standard error of trig. parallax
 109-114  F6.1   mas     plx      ? Resulting parallax
 115-119  F5.1   mas   e_plx      ? Standard error of res.  parallax
     120  A1     ---   n_plx     *[rwsop] Code on plx
 122-126  F5.2   mag     Mv       Absolute visual magnitude
 127-128  A2     ---   n_Mv       Note on Mv, copied from cols 74-75
     129  A1     ---   q_Mv      *[a-f] Quality of absolute magnitude
 132-135  I4     km/s    U        ? U space velocity component in the galactic
                                    plane and directed to the galactic center
 137-140  I4     km/s    V        ? V space velocity component in the galactic
                                    plane and in the direction of galactic
                                    rotation
 142-145  I4     km/s    W        ? W space velocity component in the galactic
                                    plane and in the direction of the
                                    North Galactic Pole
 147-152  I6     ---     HD       [15/352860]? designation
 154-165  A12    ---     DM       Durchmusterung number BD / CD / CP
 167-175  A9     ---     Giclas   number        <...>
 177-181  A5     ---     LHS      number        <...>
 183-187  A5     ---   OtherName *Other designations
 189-257  A69    ---     Remarks  Additional identifications (LTT, LFT,
                                   Wolf, Ross, etc.) and remarks
--------------------------------------------------------------------------------
Note on Name: the following acronyms are used:
     Gl   Gliese: CNS2,                                 =1969VeARI..22....1G
     GJ   Gliese & Jahreiss, A&AS, 38, 423 (1979)
     Wo   Woolley et al.,   Roy. Obs. Ann. No. 5 (1970)
     NN   newly added stars (number added at CDS)
          See the Nomemclature Note above !
Note on DistRel: the reliability of the distance is coded:
     s    trig. parallax > 0.0390 and phot. parallax    <  0.0390
     x    trig. parallax > 0.0390 and phot. parallax    <  0.0190
     p    trig. parallax < 0.0390 and phot. parallax    >  0.0390
     q    trig. parallax < 0.0390 and phot. parallax(:) >  0.0390
Note on n_RV: the following abbreviations are used:
     var  variable (?) radial velocity
     SB?  suspected spectroscopic binary
     SB   spectroscopic binary
Note on r_Sp: Selected sources (list not complete) for Sp are:
     K    Kuiper Type (see Bildelman)                   =1985ApJS...59..197K
     L    San-Gak Lee                                   =1984AJ.....89..702L
     O    objective prism MK type (but not Michigan type)
     R    Robertson type                                =1984AJ.....89.1229R
     s    Stephenson type       (Catalogue <III/123>)   =1986AJ.....91..144S
                                                        =1986AJ.....92..139S
     S    Smethells type (IAU Coll. No 76, p. 421, 1983)
     U    Upgren et al. UGP number                      =1972AJ.....77..486U
     W    Mount Wilson type
Note on r_Vmag, r_U-B, r_B-V, r_R-I:
     The following codes are used (list not complete):
     P    photographic
     *    photometric
     C    from 'Cape refractor system'
     c    calculated or transformed
     v    variable
     :    uncertain
Note on n_U-B, n_B-V, n_R-I:  This column should only contain a 'J'
     indicating joint magnitudes, but some other letters may
     also be found.
Note on n_plx: The following indicators are found:
     r    parallax from spectral types and broad-band colors
     w    photom. parallax for white dwarfs
     s    photom. parallax from Stroemgren photometry
     o    photom. parallax from Stroemgren photometry calculated by E. H. Olsen
     p    photom. parallax from other colors
Note on q_Mv: the Quality code for Mv is
     a               s.e.  <  0.10 mag
     b    0.11  <    s.e.  <  0.20
     c    0.21  <    s.e.  <  0.30
     d    0.31  <    s.e.  <  0.50
     e    0.51  <    s.e.  <  0.75
     f    0.76  <    s.e.
Note on OtherName: the following acronyms are used:
     V    Vyssotsky number (Catalogue <III/13>)
     U    UGP       number                      =1972AJ.....77..486U
     W    white dwarf  (EG or Gr number, see catalogue <III/129>)
--------------------------------------------------------------------------------

References:
    Gliese W., 1969, Veroeff. Astron. Rechen-Inst. Heidelberg, No 22
                                                =1969VeARI..22....1G
    Gliese W., Jahreiss H., data 1969-1978      =1979A&AS...38..423G

See also:
    III/13  : Vyssotsky's catalogues 1950.0 (1943-1958)
    III/129 : Spectroscopically Identified White Dwarfs, 1987,
              McCook and Sion
    V/32    : Woolley's Catalogue of stars within 25pc of the Sun
    V/35    : Gliese W., Jahreiss H., CNS2 Catalogue and nearby star data
              1969-1978

Historical notes:
  * Description initially prepared by Hartmut Jahreiss, Astronomisches
    Rechen-Institut, Moenchhofstrasse 12-14, D-6900 Heidelberg 1, GERMANY.
    The catalogue is distributed on the CD-ROM "Selected Astronomical
    Catalogs", Volume 1, 1991, directory       /combined/nearbyst
  * 05-Sep-1994: reformatted according to CDS Standards (F. Ochsenbein)
    The missing decimal points in the parallax columns (plx trplx e_plx e_trplx)
    has been added, and the blanks between the sign and the number in
    all numeric columns have been removed.
  * 04-Nov-1995: this documentation file revisited at CDS (F. Ochsenbein)
  * 04-Dec-1997: the "NN" number has been completed with a number starting
    with NN 3001 and ending with NN 4388 (See Nomenclature Notes above)
================================================================================
(End)                                    Francois Ochsenbein [CDS]   04-Nov-1995
