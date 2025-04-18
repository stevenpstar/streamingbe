-- Drop tables
DROP TABLE IF EXISTS movies CASCADE;
DROP TABLE IF EXISTS series CASCADE;
DROP TABLE IF EXISTS episodes CASCADE;

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
