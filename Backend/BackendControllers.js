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

var client = await DatabaseConnection();

/* *** Server Startup *** */
const PORT = 5000;
app.listen(PORT, () => {
    console.log(`Server has started on Port ${PORT}.`)
});

/* *** GET REQUESTS *** */
app.get('/GetContinentInformation', async (req, res) => {
    try {
        const parameters = req.query;
        const result = await client.query(`
        SELECT D.dinosaurname, F.factdescription as dinosaurfact
        FROM Continent as C
        JOIN Dinosaur_Continent as DC ON C.continentid = DC.continentid
        JOIN Dinosaur as D ON DC.dinosaurid = D.dinosaurId
        JOIN Fact as F ON D.dinosaurid = F.dinosaurid
        WHERE C.continentid = ${1}`);

        console.log(result.rows);
        res.send(result.rows);
    } catch(e) {
        res.send(e);
    }
});