SELECT 
	 TABLE_CATALOG						AS NomeDoBanco
	,TABLE_NAME							AS NomeDaTabela
	,COLUMN_NAME						AS NomeDaColuna
	,CASE
		WHEN (DATA_TYPE='nvarchar' OR DATA_TYPE ='varchar') THEN 'varchar('+CONVERT(VARCHAR,CHARACTER_MAXIMUM_LENGTH)+')'
		WHEN (DATA_TYPE='numeric' OR DATA_TYPE='money' OR DATA_TYPE='real')	THEN 'numeric('+CONVERT(VARCHAR,NUMERIC_PRECISION)+','+CONVERT(VARCHAR,NUMERIC_PRECISION_RADIX)+')'
		WHEN  DATA_TYPE='int'								THEN 'int'
		WHEN  DATA_TYPE='float'								THEN 'float'
		WHEN  DATA_TYPE='geometry'							THEN 'geometry'
		WHEN  DATA_TYPE='image'								THEN 'image'
		WHEN  DATA_TYPE='smallint'							THEN 'smallint'
	END														AS TipoDaColuna
	,CASE
		WHEN (DATA_TYPE='nvarchar' OR DATA_TYPE ='varchar') THEN 'string'
		WHEN (DATA_TYPE='numeric' OR DATA_TYPE='money' OR DATA_TYPE='real')	THEN 'decimal?'
		WHEN  DATA_TYPE='int'								THEN 'int'
		WHEN  DATA_TYPE='float'								THEN 'double'
		WHEN  DATA_TYPE='geometry'							THEN 'geometry'
		WHEN  DATA_TYPE='image'								THEN 'byte[]'
		WHEN  DATA_TYPE='smallint'							THEN 'int?'
	END														AS TipoDaColunaCSharp
 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_CATALOG = 'Geo_Juruena_2021'