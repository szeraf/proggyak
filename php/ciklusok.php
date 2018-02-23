<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Php ciklusok</title>
    <style>
        .paros { color: #f00;}
        .paratlan { color: #0f0;}
    </style>
</head>
<body>
    <?php
        if (!isset($_GET['futasszam'])) {
            $futasszam = 1;
        }else{
            $futasszam = $_GET['futasszam'] + 1;
        }
        for ($i=1; $i <= 50; $i++) { 
            print "$i ";
        }
        print "<br>";
        for ($i=1; $i <= 50; $i++) {
            print rand(10,99)." ";
        }
        print "<br>";
        $paros = 0;
        $paratlan = 0;
        for ($i=1; $i <= 50; $i++) {
            $szam = rand(10,99);
            if ($szam % 2 == 0) {
                print "<span class=\"paros\">$szam </span>";
                $paros++;
            }else if ($szam % 2 != 0) {
                print "<span class=\"paratlan\">$szam </span>";
                $paratlan++;
            }
        }
        print "<br>";
        print "paratlan: $paratlan<br>";
        print "paros: $paros<br>";
        print "futasszam: $futasszam<br>";
        print "<a href=\"ciklusok.php\">ujra</a>";

        if ($paros < 30) {
            print "<script type=\"text/javascript\">setTimeout(\"window.location='ciklusok.php?futasszam=$futasszam'\", 100);</script>";
        }
    ?>
</body>
</html>