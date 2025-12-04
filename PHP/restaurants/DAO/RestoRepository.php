<?php

class RestoRepository
{
    private ?PDO $dbConnect;
    private int $nbCol;
    private array $tabNameCol =[];

    public function __construct()
    {
        $this->dbConnect = DbConnexion::getConnexion();
        $this->nbCol=0;
    }

    public function searchAll():array
    {
        $data=[];
        $rq = "SELECT nom, adresse, prix, commentaire, note, visite FROM restaurants";
        $stmt = $this->dbConnect->query($rq);
        $data = $stmt->fetchAll();
        return $data;
    }

    public function searchById(int $_id): array
    {
        $rq = "SELECT nom, adresse, prix, commentaire, note, visite FROM restaurants WHERE id = :ID";
        $PDOstmt = $this->dbConnect->prepare($rq);
        $PDOstmt->bindValue(":ID", $_id, PDO::PARAM_INT);
        $PDOstmt->execute();
        $data = $PDOstmt->fetch();
        return $data;
    }
}

