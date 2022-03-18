create database muni
character set utf8
collate utf8_hungarian_ci;

grant all privileges 
on muni.*
to muni@localhost
identified by 'titok';

