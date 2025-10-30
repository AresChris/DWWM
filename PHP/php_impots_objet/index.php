<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Formulaire</title>
        <link rel="stylesheet" href="./style.css">
    </head>
    <body>
        <?php


        include "model/Contribuable.php";
        if (!empty($_POST["nom"]) && !empty($_POST["revenu"])) {
          
            $monContribuable = new Contribuable($_POST["nom"], floatval($_POST["revenu"]));

        echo $monContribuable->calculImpot();
        
        }else {
            echo "Veuillez remplir tous les champs";
        }
      
        ?>

        <h1>Formulaire de déclaration</h1>
        <form action="" method="post">
            <label for="nom">Nom :</label>
            <input type="text" id="nom" name="nom" value="<?php echo (!empty($_POST['nom'])) ? htmlspecialchars($_POST['nom'], ENT_QUOTES) : '' ?>" required><br>
            <label for="revenu">Revenus :</label>
            <input type="number" id="revenu" name="revenu" value="<?php echo (!empty($_POST['revenu'])) ? htmlspecialchars($_POST['revenu'], ENT_QUOTES) : '' ?>" required><br>

            <input type="submit" value="Valider">
        </form>
    </body>
</html>