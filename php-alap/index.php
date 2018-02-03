<!DOCTYPE html>
<html lang="hu">
    <head>
        <title>PHP gyak</title>
        <meta charset="utf-8">
    </head>
    <body>

        asdasdasd<br>

        <?php

            print "<b>felkover sor</b><br>";
            // egysoros comment
            /* 
                tobbsoros
                comment
            */
            $nev = "valami nev";
            print $nev;
            print "<br>";

            $date = date('Y-m-d H:i:s');
            print "<br> A pontos datum: ".$date; // osszefuzes a '.'
            print "<br> A datum megint: $date";

            $nap = date('N');
            print "<br> $nap <br>";

            if ($nap == 1) {
                print "hétfő";
            }
            if ($nap == 2) {
                print "kedd";
            }
            if ($nap == 3) {
                print "szerda";
            }
            if ($nap == 4) {
                print "csütörtök";
            }
            if ($nap == 5) {
                print "péntek";
            }
            if ($nap == 6) {
                print "szombat";
            }
            if ($nap == 7) {
                print "vasárnap";
            }
            print "<br>";

            // szamolas datummal -> 5 nap mulva
            $tday_unix = strtotime($date);
            print $tday_unix."<br>";
            $otnapmulva_unix = $tday_unix + 5*24*60*60;
            print $otnapmulva_unix."<br>";
            $otnapmulva = date('Y-m-d H:i:s', $otnapmulva_unix);
            print $otnapmulva."<br>";

        ?>

    </body>
</html>