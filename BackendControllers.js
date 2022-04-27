import express from 'express';
import cors from 'cors';
import pg from 'pg';

const app = express();
app.use((cors()));

const DatabaseConnection = async () => {
    const connectionString = "postgres://btohptbe:H5BdtF7EmtUtwHJRXS-iVto6a82iMQ8K@kashin.db.elephantsql.com/btohptbe";
    const client = new pg.Client(connectionString);
    await client.connect();

    return client;
}

var client = DatabaseConnection();

/* *** Server Startup *** */
app.listen(process.env.PORT || 5000, () => {
    console.log(`Server has started.`)
});

/* *** GET REQUESTS *** */
app.get('/GetContinentInformation/:continentId', async (req, res) => {
    try {
        const continentId = req.params.continentId;

        const result = await client.query(`
        SELECT D.dinosaurname, F.factdescription as dinosaurfact
        FROM Continent as C
        JOIN Dinosaur_Continent as DC ON C.continentid = DC.continentid
        JOIN Dinosaur as D ON DC.dinosaurid = D.dinosaurId
        JOIN Fact as F ON D.dinosaurid = F.dinosaurid
        WHERE C.continentid = ${continentId}`);

        res.send(result.rows);
    } catch(e) {
        res.send(e);
    }
});