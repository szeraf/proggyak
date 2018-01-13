<!DOCTYPE html>
<html lang="hu">
    <head>
        <title>PHP gyak</title>
        <meta charset="utf-8">
    </head>
    <body>
        <?php
            print "Szia ".$_POST['vnev']." ".$_POST['knev']."!";
            print "<br>A jelszavad: ".$_POST['pass'];

            if (isset($_POST['havi'])) {
                print "<br>Feliratkoztál a havi hírlevélre.";
            }
            else {
                print "<br>Nem iratkoztál fel a havi hírlevélre.";
            }

            if (isset($_POST['heti'])) {
                print "<br>Feliratkoztál a heti hírlevélre.";
            }
            else {
                print "<br>Nem iratkoztál fel a heti hírlevélre.";
            }


        ?>
    </body>
</html>