<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Php vektorok</title>
</head>
<body>
    <?php
        $evszakok = array("tavasz", "nyar", "osz", "tel");
        print $evszakok[1]."<br>";
        $evszakok[] = "lump";
        print $evszakok[4]."<br>";
        print count($evszakok)."<br>";
        for ($i=0; $i < count($evszakok); $i++) { 
            print $evszakok[$i]."<br>";
        }
        foreach ($evszakok as $value) {
            print $value."<br>";
        }
    ?>
</body>
</html>