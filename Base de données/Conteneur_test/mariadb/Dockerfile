# On utilise l'image de MariaDB comme base
FROM mariadb:11

ENV MYSQL_ROOT_PASSWORD=MYSQL_ROOT_PASSWORD
ENV MYSQL_DATABASE=mydatabase
ENV MYSQL_USER=chris
ENV MYSQL_PASSWORD=mypassword

# CMD apt-get install -y --fix-missing openssh-client openssh-server
#
# Différence entre CMD et RUN
#
# CMD est utilisé pour définir la commande par défaut à exécuter lorsque le conteneur démarre.
# RUN est utilisé pour exécuter des commandes lors de la construction de l'image.
#
#Met à jour la liste des paquets disponibles
RUN apt-get update
#Installe les paquets openssh-client et openssh-server
RUN apt-get install -y --fix-missing openssh-client openssh-server
