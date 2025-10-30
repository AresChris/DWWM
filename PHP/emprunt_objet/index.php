<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Welcome Page</title>
    <link rel="stylesheet" href="./style.css">
</head>
<body>
    <?php 
        include "./Pret.php";
        if (!empty($_POST["capital_emprunt"]) && !empty($_POST["taux_interet"]) && !empty($_POST["duree_remboursement"])) {
          
            $monContribuable = new Pret($_POST["capital_emprunt"], floatval($_POST["taux_interet"]), $_POST["duree_remboursement"]);

        echo $monPretMoisRemboursement->calculMoisRemboursement();
        echo $calculMensualite->calculMensualite();

        }else {
            echo "Veuillez remplir tous les champs";
        }
    ?>
    <div class="formulaire">
    <form action="">
        
        <label for="capital_emprunt">Capital emprunté</label>
        <input type="number" id="capital_emprunt" name="capital_emprunt" 
        value="<?php echo !empty($_POST['capital_emprunt']) ? htmlspecialchars($_POST['capital_emprunt']) : ''; ?>">
        
        <label for="taux_interet">Taux d'intérêt annuel (%)</label>
        <input type="number" step="0.01" id="taux_interet" name="taux_interet" 
        value="<?php echo (!empty($_POST['taux_interet'])) ? htmlspecialchars($POST['taux_interet']) : ''; ?>" required>
        
        <label for="duree_remboursement">Durée de remboursement en nb d'années</label>
        <input type="number" id="duree_remboursement" name="duree_remboursement" required>
        
        <div>
        <button type="submit">Valider</button>
        <label for="mensualite"></label>
        <input type="number" id="mensualite" name="mensualite" readonly>
        </div>

    </form>
    </div>
</body>
</html>