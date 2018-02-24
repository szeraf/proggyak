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
        session_start();

        if (isset($_GET['ujjatek'])) {
            session_destroy();
            session_start();
        }
        if (isset($_SESSION['randomszam'])) {
            $randomszam = $_SESSION['randomszam'];
            $_SESSION['randomszam'] = $randomszam;
        }else{
            $randomszam = rand(1,100);
            $_SESSION['randomszam'] = $randomszam;
        }
        if (isset($_SESSION['tippekszama'])) {
            $tippekszama = $_SESSION['tippekszama'] + 1;
            $_SESSION['tippekszama'] = $tippekszama;
        }else{
            $tippekszama = 0;
            $_SESSION['tippekszama'] = $tippekszama;
        }
        $talalt = false;

        if ( isset( $_POST[ 'submit' ] ) ) {
            if ($randomszam > $_POST['tipp']) {
                print "<p>Nagyobb szamra gondoltam, probalkozz ujra!</p>";
            }else if ($randomszam < $_POST['tipp']) {
                print "<p>Kisebb szamra gondoltam, probalkozz ujra!</p>";
            }else {
                print "<p>Talalt!<br>$tippekszama tipp utan.</p>
                        <a href=\"szamkitalalo-session.php?ujjatek\"><button autofocus>Uj jatek</button></a>
                        <audio autoplay><source src=\"./celeb.mp3\" type=\"audio/mpeg\"></audio>";
                $talalt = true;
            }
        }

        if (!$talalt) {
            print "<p>Gondoltam egy szamra 1 es 100 kozott, add meg a tipped!</p>
                <form method=\"post\" action=\"szamkitalalo-session.php\">
                    <input type=\"number\" name=\"tipp\" min=\"1\" max \"100\" autofocus>
                    <input type=\"submit\" name=\"submit\" value=\"Tippelek!\">
                </form>";
        }
    ?>
</body>
</html>