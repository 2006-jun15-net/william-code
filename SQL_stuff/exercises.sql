-- ex 1
SELECT * FROM Artist WHERE ArtistId
NOT IN (SELECT ArtistId FROM Album);

SELECT * FROM Artist AS art
WHERE art.ArtistId NOT IN
(SELECT DISTINCT al.ArtistId FROM Album AS al)
-- End ex1

-- ex 2
SELECT * FROM Artist AS art
LEFT JOIN Track AS t
ON t.GenreId = art.ArtistId

SELECT * FROM Artist AS art
LEFT JOIN
(SELECT Track.A FROM Track)
--end ex2

-- ex 3
SELECT * FROM MediaType

-- End ex 3