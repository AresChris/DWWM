<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calcul Impôt</title>
    <link rel="stylesheet" href="assets/css/style.css">
</head>
<body>

<?php
    include "./models/Contribuable.php";
    $message = "";
    if (isset($_POST["envoi"])) {
        if (!empty($_POST["nom"]) && !empty($_POST["revenu"]) ) {
        $monContribuable = new Contribuable($_POST["nom"], floatval($_POST["revenu"]));
        $montant = $monContribuable->calculImpot();
    } else {
        $message="Veuillez remplir tous le champs";
    }
}
   
?>
    <div class="container">
        <form method="POST" action="<?php echo $_SERVER["PHP_SELF"]  ?>" enctype="multipart/form-data" >
            <fieldset>
                <legend>Calcul de l'Impôt sur le Revenu</legend>

                <label for="nom">Nom Contribuable</label>
                <input type="text" id="nom" name="nom" value="<?php echo $_POST["nom"] ?? "Nom" ?>" >

                <label for="revenu">Revenu Annuel</label>
                <input type="number" id="revenu" name="revenu" min="0" value="<?php echo $_POST["revenu"] ?? "0"  ?>" required>

                <button type="submit" name="envoi" >Calculer</button>

                <label for="impot">Impôt sur le revenu annuel</label>
                <input type="text" id="impot" name="impot" value="<?php echo (!empty($montant)) ? $montant : '0 €' ?>" readonly>
                    <div id="summary"><?php echo $message;?></div>
            </fieldset>
        </form>
    </div>
</body>
</html>