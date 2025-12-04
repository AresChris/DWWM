<?php

class DbConnexion
{
    private const HOST = 'localhost';
    private const DBNAME = 'restaurants';
    private const USER = 'root';
    private const PASS = '';
    private static ?PDO $connexion = null;

    private function __construct(){}
    
    public static function getConnexion(): PDO
    {
        if (self::$connexion === null) {
            self::$connexion = new PDO(
                'mysql:host=' . self::HOST . ';dbname=' . self::DBNAME,
                self::USER,
                self::PASS
            );
        }
        return self::$connexion;
    }
}