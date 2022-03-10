# COSC4397_ARDinosaurs
Group Members:
- Shaheer Khan,
- Reeba Sayed
- Hoang Phan
- Victor Rodriguez

## Dinosaurs by Continents and Facts:
North America: Triceratops
Facts:
- Triceratops means "three-horned-face" in Greek.
- Triceratops skull was one-third of it's body.
- Had on average around 800 teeth.

South America: Argentinosaurus
Facts:
- The largest land-mammal weighing up to 220,000lbs and up to 130 feet in length.
- Clocked in at a blazing top-speed of 5mph.
- This dinosaur took up to 40 years to reach it's maximum size.

Asia: Tyrannosaurus Rex
Facts:
- Tyrannosaurus Rex means "King of the Tyrant Lizards" in Greek.
- Could exert 57,000 newtons of force with it's bite.
- Teeth could grow up to 12 inches long.

Europe: Balaur
Facts:
- Interpretted to be a flightless bird instead of a lizard.
- Had large, retractable sickle claws on both the first and second toes of each foot.
- Thought to have evolved in this shape, due to being cut off from it's cousin on the mainland, the Velociraptor.

Africa: Spinosaurus
Facts:
- Carnivorous dinosaur that was larger than even the Tyrannosaurus Rex.
- Sail on their back could grow as high as 7-feet.
- Paleontologiest beleive this dinosaur had the ability to swim.

Australia and Antartica: Pterosaur
Facts:
- Bones were hollow, which enabled the reptile to be light enough to fly.
- First animal, after insects, to evolve and gain powered flight.
- On land, this creature walked on all fours (legs and wings).

## Database Schema:
Dinosaur:
- (PK) DinosaurId
- DinosaurName (VARCHAR NOT NULL)

Continent:
- (PK) ContinentId
- ContinentName (VARCHAR NOT NULL)

Dinosaur_Continent:
- (PK) Dinosaur_ContinentId
- (FK) DinosaurId
- (FK) ContinentId

Facts:
- (PK) FactId
- FactDescription (VARCHAR NOT NULL)
- (FK) DinosaurId