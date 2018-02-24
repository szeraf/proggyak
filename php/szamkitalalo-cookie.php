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
        if (isset($_GET['ujjatek'])) {
            unset($_COOKIE['randomszam']);
            unset($_COOKIE['tippekszama']);
        }
        if (isset($_COOKIE['randomszam'])) {
            $randomszam = $_COOKIE['randomszam'];
            setcookie("randomszam",$randomszam,time()+3600);
        }else{
            $randomszam = rand(1,100);
            setcookie("randomszam",$randomszam,time()+3600); // 1h expir
        }
        if (isset($_COOKIE['tippekszama'])) {
            $tippekszama = $_COOKIE['tippekszama'] + 1;
            setcookie("tippekszama",$tippekszama,time()+3600);
        }else{
            $tippekszama = 0;
            setcookie("tippekszama",$tippekszama,time()+3600); // 1h expir
        }
        $talalt = false;

        if ( isset( $_POST[ 'submit' ] ) ) {
            if ($randomszam > $_POST['tipp']) {
                print "<p>Nagyobb szamra gondoltam, probalkozz ujra!</p>";
            }else if ($randomszam < $_POST['tipp']) {
                print "<p>Kisebb szamra gondoltam, probalkozz ujra!</p>";
            }else {
                print "<p>Talalt!<br>$tippekszama tipp utan.</p><a href=\"szamkitalalo-cookie.php?ujjatek\"><button autofocus>Uj jatek</button></a>";
                $talalt = true;
            }
        }

        if (!$talalt) {
            print "<p>Gondoltam egy szamra 1 es 100 kozott, add meg a tipped!</p>
                <form method=\"post\" action=\"szamkitalalo-cookie.php\">
                    <input type=\"number\" name=\"tipp\" min=\"1\" max \"100\" autofocus>
                    <input type=\"submit\" name=\"submit\" value=\"Tippelek!\">
                </form>";
        }
    ?>
</body>
</html>