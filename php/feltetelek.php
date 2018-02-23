<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Php feltetelek</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
        .hibauzenet { color: #f00; font-weight: bold;}
    </style>
</head>
<body>
    <?php
        if ( !isset( $_GET[ 'submit' ] ) ) {
            print "<form method=\"GET\" action=\"\">
                    Ird be az elso szamot: <input type=\"number\" name=\"szam1\"><br>
                    Ird be a masodik szamot: <input type=\"number\" name=\"szam2\"><br>
                    <input type=\"submit\" name=\"submit\" value=\"Kuldes\">
                   </form>";
        }else{
            if ($_GET['szam1'] == "") {
                print "<span class=\"hibauzenet\">
                        Hianyzik az elso szam!
                        </span><br>";
            }else{
                print "Az elso megadott szam: ".$_GET['szam1']."<br>";
            }
            if ($_GET['szam2'] == "") {
                print "<span class=\"hibauzenet\">
                        Hianyzik a masodik szam!
                        </span><br>";
            }else{
                print "A masodik megadott szam: ".$_GET['szam2']."<br>";
            }
            if ($_GET['szam1'] != "" && $_GET['szam2'] != "") {
                if ($_GET['szam1'] > $_GET['szam2']) {
                    print "Az elso szam nagyobb mint a masodik.<br>";
                }else if ($_GET['szam1'] == $_GET['szam2']) {
                    print "A ket szam egyenlo.<br>";
                }else {
                    print "A masodik szam nagyobb mint az elso.<br>";
                }
                if (($_GET['szam1'] + $_GET['szam2']) % 2 != 0) {
                    print "Csak az egyik szam paros.<br>";
                }
                if (($_GET['szam1'] % 2) == 0 && ($_GET['szam2'] % 2) != 0) {
                    print "Az elso szam paros.<br>";
                }else if (($_GET['szam1'] % 2) != 0 && ($_GET['szam2'] % 2) == 0) {
                    print "A masodik szam paros.<br>";
                }else if (($_GET['szam1'] % 2) == 0 || ($_GET['szam2'] % 2) == 0) {
                    print "A megadott szamok kozt van paros.<br>";
                }
                if (($_GET['szam1'] % 2) != 0 && ($_GET['szam2'] % 2) != 0) {
                    print "Mindket szam paratlan.<br>";
                }
            }
            
        }

    ?>
</body>
</html>