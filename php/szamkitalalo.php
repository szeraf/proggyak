<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Szamkitalalos Jatek</title>
</head>
<body>
    <?php
        $randomszam = rand(1,100);
        $talalt = false;
        $tippekszama = 0;

        if ( isset( $_POST[ 'submit' ] ) ) {
            $randomszam = $_POST['randomszam'];
            $tippekszama = $_POST['tippekszama'] + 1;
            if ($randomszam > $_POST['tipp']) {
                print "<p>Nagyobb szamra gondoltam, probalkozz ujra!</p>";
            }else if ($randomszam < $_POST['tipp']) {
                print "<p>Kisebb szamra gondoltam, probalkozz ujra!</p>";
            }else {
                print "<p>Talalt!<br>$tippekszama tipp utan.</p><a href=\"\"><button autofocus>Uj jatek</button></a>";
                $talalt = true;
            }
        }

        if (!$talalt) {
            print "<p>Gondoltam egy szamra 1 es 100 kozott, add meg a tipped!</p>
                <form method=\"post\" action=\"\">
                    <input type=\"number\" name=\"tipp\" min=\"1\" max \"100\" autofocus>
                    <input type=\"hidden\" name=\"randomszam\" value=\"$randomszam\">
                    <input type=\"hidden\" name=\"tippekszama\" value=\"$tippekszama\">
                    <input type=\"submit\" name=\"submit\" value=\"Tippelek!\">
                </form>";
        }
    ?>
</body>
</html>