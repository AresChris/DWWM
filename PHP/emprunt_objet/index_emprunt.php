<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Welcome Page</title>
    <link rel="stylesheet" href="./assets/style.css">
</head>

<body>
    <?php
    include "./Pret.php";
    $message = "";
    if (!empty($_POST["capital_emprunt"]) && !empty($_POST["taux_interet"]) && !empty($_POST["duree_remboursement"])) {

        $monPret = new Pret($_POST["capital_emprunt"], floatval($_POST["taux_interet"]), $_POST["duree_remboursement"]);


        $calculMensualite = $monPret->calculMensualite();
        $tableauAmortissement = $monPret->tableauAmortissement();
    } else {
        $message = "Veuillez remplir tous les champs";
        $tableauAmortissement = '';
    }
    ?>
    <div class="formulaire">
        <form method="POST" action="">

            <label for="capital_emprunt">Capital emprunté</label>
            <input type="number" id="capital_emprunt" name="capital_emprunt" value="<?php echo isset($_POST['capital_emprunt']) ? htmlspecialchars($_POST['capital_emprunt']) : '' ?>">

            <label for="taux_interet">Taux d'intérêt annuel (%)</label>
            <input type="number" step="0.01" id="taux_interet" name="taux_interet" value="<?php echo isset($_POST['taux_interet']) ? htmlspecialchars($_POST['taux_interet']) : '' ?>" required>

            <label for="duree_remboursement">Durée de remboursement en nombre d'années</label>
            <input type="number" id="duree_remboursement" name="duree_remboursement" value="<?php echo isset($_POST['duree_remboursement']) ? htmlspecialchars($_POST['duree_remboursement']) : '' ?>" required>

            <div>
                <button type="submit">Valider</button>
                <label for="mensualite">Mensualités</label>
                <input type="number" id="mensualite" name="mensualite" value="<?php echo $calculMensualite ?? '0 €' ?>" readonly>
            </div>
            <div id="summary"><?php echo $message; ?></div>
        </form>
        <div id="tableau_amortissement"><?php echo $tableauAmortissement ?? ''; ?></div>
    </div>

</body>

</html>