INSERT INTO movies (title, poster, filepath, filetype)
VALUES ('Keeper of the Bees', 'keeperposter.png', 'wwwroot/Assets/Keeper_of_the_Bees_512kb.mp4', 'video/mp4');

INSERT INTO movies (title, poster, filepath, filetype)
VALUES ('Nosferatu', 'nosferatuposter.png', 'wwwroot/Assets/Nosferatu.mpeg4', 'video/mpeg-4');

-- Nosferatu Cast
INSERT INTO actors (name, picture)
  VALUES ('Max Schreck', 'wwwroot/Assets/nosferatu_cast/Max_Schreck_1922.jpg');

INSERT INTO actors (name, picture)
  VALUES ('Gustav von Wangenheim', 'wwwroot/Assets/nosferatu_cast/Gustav_von_Wangenheim_1922.jpg');

INSERT INTO actors (name, picture)
  VALUES ('Greta Schroeder', 'wwwroot/Assets/nosferatu_cast/GretaSchroeder1919.jpg');

-- Create relations from Nosferatu movie to Cast

INSERT INTO moviecast(movieid, actorid, charactername)
VALUES (
  (SELECT movieid FROM movies WHERE title = 'Nosferatu'),
  (SELECT actorid FROM actors WHERE name = 'Max Schreck'),
  'Graf Orlok');

INSERT INTO moviecast(movieid, actorid, charactername)
VALUES (
  (SELECT movieid FROM movies WHERE title = 'Nosferatu'),
  (SELECT actorid FROM actors WHERE name = 'Gustav von Wangenheim'),
  'Hutter');

INSERT INTO moviecast(movieid, actorid, charactername)
VALUES (
  (SELECT movieid FROM movies WHERE title = 'Nosferatu'),
  (SELECT actorid FROM actors WHERE name = 'Greta Schroeder'),
  'Ellen');

-- Nosferatu Thumbnails

INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00001.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00002.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00002.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00003.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00004.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00005.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00006.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00007.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00008.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00009.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00010.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00011.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00012.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00013.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00014.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00015.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00016.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00017.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00018.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00019.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00020.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00021.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00022.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00023.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00024.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00025.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00026.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00027.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00028.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00029.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00030.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00031.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00032.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00033.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00034.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00035.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00036.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00037.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00038.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00039.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00040.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00041.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00042.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00043.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00044.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00045.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00046.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00047.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00048.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00049.jpeg');
INSERT INTO thumbnails (movieid, filename) VALUES (2, 'wwwroot/Assets/nosferatu_th/thumb_00050.jpeg');

