-- Drop tables
DROP TABLE IF EXISTS movies CASCADE;
DROP TABLE IF EXISTS series CASCADE;
DROP TABLE IF EXISTS episodes CASCADE;
DROP TABLE IF EXISTS thumbnails CASCADE;
DROP TABLE IF EXISTS actors CASCADE;
DROP TABLE IF EXISTS moviecast CASCADE;

-- Create tables
CREATE TABLE movies (
  movieid serial PRIMARY KEY,
  title varchar(100),
  poster varchar(256),
  filepath varchar(256),
  filetype varchar(50)
);

CREATE TABLE series (
  seriesid serial PRIMARY KEY,
  title varchar(100)
);

CREATE TABLE episodes (
  episodeid serial PRIMARY KEY,
  seriesid integer references series(seriesid)
);

CREATE TABLE thumbnails (
  thumbid serial PRIMARY KEY,
  movieid integer references movies(movieid),
  filename varchar(100)
);

CREATE TABLE actors (
  actorid serial PRIMARY KEY,
  name varchar(100),
  picture varchar(100)
);

CREATE TABLE moviecast (
  moviecastid serial PRIMARY KEY,
  movieid integer references movies(movieid),
  actorid integer references actors(actorid),
  charactername varchar(100)
);
