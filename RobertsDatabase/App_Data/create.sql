CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY AUTOINCREMENT,
								  username TEXT NOT NULL UNIQUE,
								  pass TEXT NOT NULL);
								 
CREATE TABLE IF NOT EXISTS RL (id INTEGER PRIMARY KEY AUTOINCREMENT,
									Trade TEXT NOT NULL,
								    Class TEXT NOT NULL,
                               		Description TEXT NOT NULL,
                               		Project TEXT NOT NULL,
                             		Ref TEXT NOT NULL,
                               		Rate INTEGER NOT NULL,
                               		UoM TEXT NOT NULL);

INSERT OR IGNORE INTO RL VALUES (1, 'John', 'Blogs', '0455515641', 'John@sample.com', 12, 'admin',12);
INSERT OR IGNORE INTO RL VALUES (2, 'Jenny', 'Doe', '0455541115', 'Jenny@sample.com', 14, 'admin',12);
INSERT OR IGNORE INTO RL VALUES (3, 'Jim', 'Cloud', '0455514544', 'Jim@sample.com', 45, 'admin',12);
INSERT OR IGNORE INTO RL VALUES (4, 'Jack', 'Dan', '0455554751', 'Jack@sample.com', 22, 'admin',12);