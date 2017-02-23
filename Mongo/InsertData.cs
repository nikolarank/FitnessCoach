using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo.DataAccess;
using Mongo.Documents;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Mongo
{
    public static class InsertData
    {
        public static void Insert()
        {
            //korisnici
            Korisnik k1 = new Korisnik()
            {
                Ime = "Nikola",
                Prezime = "Rankovic",
                Korisnicko_Ime = "Nikola",
                Sifra = "Nikola",
                Email = "nikolarank94@gmail.com",
                Biografija = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Broj_Ocenjivanja = 0,
                Rang = 9.0,
                Status = "administrator",
                Moj_Instruktor = null,
                Slika = "Nikola.jpg",
                Zahtev_Za_Instruktora = false
            };
            Korisnici.Dodaj(k1);

            Korisnik k2 = new Korisnik()
            {
                Ime = "Predrag",
                Prezime = "Cukalovic",
                Korisnicko_Ime = "Predrag",
                Sifra = "Predrag",
                Email = "predrag.cukalovic@gmail.com",
                Biografija = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Broj_Ocenjivanja = 0,
                Rang = 9.0,
                Status = "administrator",
                Moj_Instruktor = null,
                Slika = "Predrag.jpg",
                Zahtev_Za_Instruktora = false
            };
            Korisnici.Dodaj(k2);

            Korisnik k3 = new Korisnik()
            {
                Ime = "Nebojsa",
                Prezime = "Rankovic",
                Korisnicko_Ime = "Nebojsa",
                Sifra = "Nebojsa",
                Email = "nesa.rank0@gmail.com",
                Biografija = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Broj_Ocenjivanja = 0,
                Rang = 9.0,
                Status = "fitnes_instruktor",
                Moj_Instruktor = null,
                Slika = "Nebojsa.jpg",
                Zahtev_Za_Instruktora = false
            };
            Korisnici.Dodaj(k3);

            Korisnik k6 = new Korisnik()
            {
                Ime = "Michelle",
                Prezime = "Lewin",
                Korisnicko_Ime = "Michelle",
                Sifra = "Michelle",
                Email = "michellelewin@gmail.com",
                Biografija = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Broj_Ocenjivanja = 0,
                Rang = 9.0,
                Status = "fitnes_instruktor",
                Moj_Instruktor = null,
                Slika = "Michelle.jpg",
                Zahtev_Za_Instruktora = false
            };
            Korisnici.Dodaj(k6);

            Korisnik k4 = new Korisnik()
            {
                Ime = "Marko",
                Prezime = "Radosavljevic",
                Korisnicko_Ime = "Marko",
                Sifra = "Marko",
                Email = "radmarko94@gmail.com",
                Biografija = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Broj_Ocenjivanja = 0,
                Rang = 9.0,
                Status = "korisnik",
                Moj_Instruktor = new MongoDBRef("korisnici", k3.Id),
                Slika = "Marko.jpg",
                Zahtev_Za_Instruktora = false
            };
            Korisnici.Dodaj(k4);

            Korisnik k5 = new Korisnik()
            {
                Ime = "Lazar",
                Prezime = "Manojlovic",
                Korisnicko_Ime = "Lazar",
                Sifra = "Lazar",
                Email = "lazarmanojlo94@gmail.com",
                Biografija = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Broj_Ocenjivanja = 0,
                Rang = 9.0,
                Status = "korisnik",
                Moj_Instruktor = new MongoDBRef("korisnici", k6.Id),
                Slika = "Lazar.jpg",
                Zahtev_Za_Instruktora = false
            };
            Korisnici.Dodaj(k5);


            //vezbe
            Vezba v1 = new Vezba()
            {
                Naziv = "Ab Crunch",
                Misicna_Partija = "abs",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "AbCrunch.jpg",
                Tekst = "Lie face up on floor, knees bent with feet on floor and neck straight. Cross arms over chest. In a controlled motion, keeping neck straight, curl upper body up. Contract abdominals fully without compromising form. While maintaining the controlled motion, return to starting position. Do not allow muscle to relax before next repetition."
            };
            Vezbe.Dodaj(v1);

            Vezba v2 = new Vezba()
            {
                Naziv = "Ab Crunch Obliques",
                Misicna_Partija = "abs",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "AbCrunchObliques.jpg",
                Tekst = "Lie face up on floor, knees bent with feet on floor and neck straight. Cross arms over chest. In a controlled motion, keeping neck straight, curl upper body up while turning your torso to the left. Contract abdominals fully without compromising form. While maintaining the controlled motion, return to starting position. Do not allow muscle to relax before next repetition. After completing one set on the left, switch to your right side. Focus on really twisting your torso and feeling the contraction when you are in the up position."
            };
            Vezbe.Dodaj(v2);

            Vezba v3 = new Vezba()
            {
                Naziv = "Back Extension",
                Misicna_Partija = "back",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BackExtension.jpg",
                Tekst = "Lock feet in, with pad comfortably on hips. Cross arms over chest. If using weight, hold weight plate at chest level. Pressing hips into the pad, relax the spine. Squeeze together (retract) shoulder blades. In a controlled motion, lift head and shoulders up until spine is comfortably hyperextended. Avoid hyperextending the neck. Maintaining controlled motion, return to starting position. Do not allow muscles to relax before next repetition."
            };
            Vezbe.Dodaj(v3);

            Vezba v4 = new Vezba()
            {
                Naziv = "Ball Band Arm Row",
                Misicna_Partija = "back",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallBandArmRow.jpg",
                Tekst = "Position the dumbbells to your sides. Keep your head up, back straight and your knees slightly bent. Bend at the waist and lean forward until your upper body is parallel to the ground. Pause briefly then return to the starting position. Do not allow muscles to relax before next repetition."
            };
            Vezbe.Dodaj(v4);

            Vezba v5 = new Vezba()
            {
                Naziv = "Arm Curl Machine",
                Misicna_Partija = "biceps",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "ArmCurlMachine.jpg",
                Tekst = "Adjust seat so that it is not so low that the shoulders are elevated nor so high that you are hunched over the pad. Position elbows on pad, and grasp bar with an underhand grip. Raise the bar until elbows are fully flexed with the back of the upper arms remaining on the pad. Lower the bar until arms are fully extended. Do not allow muscles to relax before next repetition."
            };
            Vezbe.Dodaj(v5);

            Vezba v6 = new Vezba()
            {
                Naziv = "Ball Band Biceps Curl",
                Misicna_Partija = "biceps",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallBandBicepsCurl.jpg",
                Tekst = "Primary Muscle Group: Front upper arms Muscle Groups Worked in This Exercise: Biceps brachii (long and short heads and Brachialis Preparation: Sit on the ball with the band under both feet. Grasp each end of the band with each hand. Extend your arms fully toward the floor with your palms facing away from your upper body. Breathing: Exhale as you bend your arms and inhale as you lower back to start position. Execution: Bend your arms and lift your hands to your shoulders. Return to starting position."
            };
            Vezbe.Dodaj(v6);

            Vezba v7 = new Vezba()
            {
                Naziv = "Ball Dumbbell Chest Flys",
                Misicna_Partija = "chest",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallDumbbellChestFlys.jpg",
                Tekst = "Primary Muscle Group: Chest, abs, thighs.Muscle Groups Worked in This Exercise: Anterior Deltoids, Pectoralis Major, Rectus Abdominus, QuadricepsPreparation: Lie with your upper back, neck and head supported by the ball. Grasp a dumbbell in each hand and bend your elbows in a circular manner to your body.Breathing: Exhale when pressing hands up in a circular motion as if you were hugging a tree, inhale as you return them to start position.Execution: As you bring your hands towards together over your chest in a circular form, exhale. Inhale as you bring your hands back down to starting position."
            };
            Vezbe.Dodaj(v7);

            Vezba v8 = new Vezba()
            {
                Naziv = "Ball Dumbbell Pullover",
                Misicna_Partija = "chest",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallDumbbellPullover.jpg",
                Tekst = "Primary Muscle Group: Chest - Pectoralis MajorMuscle Groups Worked in This Exercise: Latissimus Dorsi, Teres Major, Triceps, Long Head, Deltoid, Posterior, Pectoralis Minor, Rhomboids and Levator ScapulaePreparation: Sit in an upright position on a stability ball with feet flat on floor while holding a single dumbbell in both hands. Walk feet forward allowing the stability ball to roll underneath of your body until it is postioned on the middle to upper part of your back region. Rest head on stability ball. Raise your hips to create a straight surface parallel to the floor. Place Dumbbell on chest with handle perpendicular to your chest.Breathing: Inhale and lower the dumbbell and exhale as you start the move upward to the starting position.Execution: Extend your elbows and raise the dumbbell even with your eyeline. With your elbows slightly bent, lower the dumbbell back even to slightly below your head level. Return to the starting position. Keep both feet flat on the floor at all times and keep your lower back in a neutral position. Do not lock out your elbows or arch your back which may cause injury."
            };
            Vezbe.Dodaj(v8);

            Vezba v9 = new Vezba()
            {
                Naziv = "Ball Dumbbell Squats",
                Misicna_Partija = "legs",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallDumbbellSquats.jpg",
                Tekst = "Primary Muscle Group: Quadriceps femoris, GluteusMuscle Groups Worked in This Exercise: Thigh Flexors, GlutesPreparation: Place a ball between your back and the wall and inch your feet away from the wall and let your body weight lean into the ball. Your feet should be about 1 to 1.5 feet in front of your hips. Hold the dumbbells up in your hands next to your shoulders.Breathing: Inhale when sliding your back (and the ball) down the wall; exhale when rising to standing position.Execution: Bend your elbows and bring your hands to shoulder level with dumbbells in hand. Maintaining a constant pressure with your back on the ball, roll it down the wall, while bending your knees until they reach 90 degrees. Pause, exhale and return to a standing position."
            };
            Vezbe.Dodaj(v9);

            Vezba v10 = new Vezba()
            {
                Naziv = "Ball Lunge",
                Misicna_Partija = "legs",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallLunge.jpg",
                Tekst = "Primary Muscle Group: Gluteus Maximus Muscle Groups Worked in This Exercise: Gluteus Maximus, Quadriceps (Rectus femoris, vastus lateralis, vastus medialis and vastus intermedius) Preparation: Begin with the ball on your right side. Rest your hand on top and take a big step forward with your left leg. Breathing: Inhale as you bend, exhale as you straighten your leg. Execution: As you bend your left knee, inhale and sink down into the lunge. As you rise to the starting position, exhale. Switch sides after finishing all reps."
            };
            Vezbe.Dodaj(v10);

            Vezba v11 = new Vezba()
            {
                Naziv = "Ball Band Lateral Raise",
                Misicna_Partija = "shoulders",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallBandLateralRaise.jpg",
                Tekst = "Muscle Groups Worked in This Exercise: Trapezius, Deltoideus (anterior and middle) Preparation: Sit on the ball, keeping your back straight, your abs tight and secure an exercise band under both feet. Grasp the band in both hands and fully extend your arms by your hips. Palms should be facing the ball. Breathing: Exhale when raising arms, inhale when lowering to start. Execution: Raise your arms out to the sides, palms facing down, until they are at shoulder level. Inhale and lower them back to start. Comments: This will make your shoulders beautifully toned and shapely!"
            };
            Vezbe.Dodaj(v11);

            Vezba v12 = new Vezba()
            {
                Naziv = "Ball Band Upright Row",
                Misicna_Partija = "shoulders",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallBandUprightRow.jpg",
                Tekst = "Muscle Groups Worked in This Exercise: Anterior Deltoid, Lateral Deltoid, Middle and Lower Trapezius, Preparation: Grasp dumbbells in both hands. The Dumbbells should be positioned in front of your body hanging straight down in front of you.Breathing: Breath out on the contraction of the muscle and breath back in on the way back to the start position.Execution: Raise both dumbbells with elbows fixed in a 10 to 30 degree angle throughout until upper arms are parallel to the floor. Repeat movement."
            };
            Vezbe.Dodaj(v12);

            Vezba v13 = new Vezba()
            {
                Naziv = "Ball Band Triceps Kick Back",
                Misicna_Partija = "triceps",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BallBandTricepsKickBack.jpg",
                Tekst = "Muscle Groups Worked in This Exercise: Triceps brachii (lateral and long heads) and that seldom heard of muscle, Anconeus Preparation: Sit on the ball and bend forward to about 45 degrees. Place the exercise band under both feet and grasp the ends of the band. Extend your arms toward the floor with your palms facing in. Bring your elbows up towards the ceiling and your hands in towards your ribcage. Breathing: Exhale when extending arms, inhale as you return to start position. Execution: Extend your arms behind your upper body and exhale. As you return to starting position, inhale. Keep your upper arms and shoulders steady and bend only at the elbows. Keep your abs engaged. Comments: Say goodbye to underarm sag!"
            };
            Vezbe.Dodaj(v13);

            Vezba v14 = new Vezba()
            {
                Naziv = "Band Kick Backs",
                Misicna_Partija = "triceps",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Slika = "BandKickBacks.jpg",
                Tekst = "Muscle Groups Worked in This Exercise: Triceps brachii; medial, lateral and long heads, as well as a little mentioned muscle, the Anconeus Preparation: Stand with your feet in a shoulder-width, split stance and place the resistance band under your back foot. Dont forget to keep your abs tight. Grasp the handle of the band (reach behind you) with an inverted palm-in grip, with the opposite hand to the foot that is on the band. Breathing: Breathe out as you straighten your arm; breathe in when you return to start position. Execution: Extend your arm over your head and bend your elbow so your forearm is now behind your head. Keep your upper arm vertical throughout this range of motion. Now, slowly extend your arm and push the handle up until your entire arm is straight. Pause. Bend your arm back to start position. After completing all reps, do the same for the other arm. Comments: Imagine you are going to pound in a nail for a picture, up high. This should help you with the movement. Be sure that your neck remains neutral throughout the movement by looking straight ahead."
            };
            Vezbe.Dodaj(v14);


            Namirnica n1 = new Namirnica
            {
                Naziv = "Beef, extract, bonox",
                Kalorije = "401",
                Masti = "16.6",
                Proteini = "6.5",
                Uh = "0.2"
            };


            Namirnica n2 = new Namirnica
            {
                Naziv = "Basil, dried",
                Kalorije = "1079",
                Masti = "18.2",
                Proteini = "15.5",
                Uh = "5.5"
            };

            Namirnica n3 = new Namirnica
            {
                Naziv = "Cardamom, seeds, ground",
                Kalorije = "1333",
                Masti = "10.8",
                Proteini = "40.5",
                Uh = "6.7"
            };

            Namirnica n4 = new Namirnica
            {
                Naziv = "Chilli (chili) powder",
                Kalorije = "1441",
                Masti = "12.3",
                Proteini = "20.5",
                Uh = "16.8"
            };

            Namirnica n5 = new Namirnica
            {
                Naziv = "Chilli (chili), dried, ground",
                Kalorije = "1573",
                Masti = "14.1",
                Proteini = "29.6",
                Uh = "16.8"
            };

            Namirnica n6 = new Namirnica
            {
                Naziv = "Cinnamon, dried, ground",
                Kalorije = "1026",
                Masti = "4.2",
                Proteini = "25.5",
                Uh = "2.7"
            };

            Namirnica n7 = new Namirnica
            {
                Naziv = "Cloves, dried, ground",
                Kalorije = "1536",
                Masti = "6",
                Proteini = "30.8",
                Uh = "17.3"
            };

            Namirnica n8 = new Namirnica
            {
                Naziv = "Coriander seed, dried, ground",
                Kalorije = "1476",
                Masti = "13",
                Proteini = "10.5",
                Uh = "19.8"
            };

            Namirnica n9 = new Namirnica
            {
                Naziv = "Cumin (cummin) seed, dried, ground",
                Kalorije = "1915",
                Masti = "18.4",
                Proteini = "33.3",
                Uh = "25.8"
            };

            Namirnica n10 = new Namirnica
            {
                Naziv = "Curry powder",
                Kalorije = "1459",
                Masti = "12.7",
                Proteini = "30.9",
                Uh = "13.8"
            };

            Namirnica n11 = new Namirnica
            {
                Naziv = "Fenugreek seed",
                Kalorije = "1375",
                Masti = "23",
                Proteini = "33.8",
                Uh = "6.4"
            };

            Namirnica n12 = new Namirnica
            {
                Naziv = "Ginger, dried, ground",
                Kalorije = "1418",
                Masti = "8.5",
                Proteini = "58.6",
                Uh = "4.6"
            };

            Namirnica n13 = new Namirnica
            {
                Naziv = "Herbs, mixed, dried",
                Kalorije = "1210",
                Masti = "11.1",
                Proteini = "22",
                Uh = "9"
            };

            Namirnica n14 = new Namirnica
            {
                Naziv = "Mustard powder",
                Kalorije = "2289",
                Masti = "29.4",
                Proteini = "17.2",
                Uh = "39.5"
            };

            Namirnica n15 = new Namirnica
            {
                Naziv = "Nutmeg, dried, ground",
                Kalorije = "2119",
                Masti = "6.4",
                Proteini = "27.5",
                Uh = "37.6"
            };

            Namirnice.Dodaj(n1);
            Namirnice.Dodaj(n2);
            Namirnice.Dodaj(n3);
            Namirnice.Dodaj(n4);
            Namirnice.Dodaj(n5);
            Namirnice.Dodaj(n6);
            Namirnice.Dodaj(n7);
            Namirnice.Dodaj(n8);
            Namirnice.Dodaj(n9);
            Namirnice.Dodaj(n10);
            Namirnice.Dodaj(n11);
            Namirnice.Dodaj(n12);
            Namirnice.Dodaj(n13);
            Namirnice.Dodaj(n14);
            Namirnice.Dodaj(n15);

            Obrok o1 = new Obrok
            {
                Redni_Broj_Obroka = 1,
                Namirnice = new List<MongoDBRef>()
            };

            o1.Namirnice.Add(new MongoDBRef("namirnice", n1.Id));
            o1.Namirnice.Add(new MongoDBRef("namirnice", n2.Id));
            o1.Namirnice.Add(new MongoDBRef("namirnice", n3.Id));


            Obrok o2 = new Obrok
            {
                Redni_Broj_Obroka = 2,
                Namirnice = new List<MongoDBRef>()
            };

            o2.Namirnice.Add(new MongoDBRef("namirnice", n4.Id));
            o2.Namirnice.Add(new MongoDBRef("namirnice", n5.Id));
            o2.Namirnice.Add(new MongoDBRef("namirnice", n6.Id));


            Obrok o3 = new Obrok
            {
                Redni_Broj_Obroka = 3,
                Namirnice = new List<MongoDBRef>()
            };

            o3.Namirnice.Add(new MongoDBRef("namirnice", n7.Id));
            o3.Namirnice.Add(new MongoDBRef("namirnice", n8.Id));
            o3.Namirnice.Add(new MongoDBRef("namirnice", n9.Id));


            Obrok o4 = new Obrok
            {
                Redni_Broj_Obroka = 4,
                Namirnice = new List<MongoDBRef>()
            };

            o4.Namirnice.Add(new MongoDBRef("namirnice", n10.Id));
            o4.Namirnice.Add(new MongoDBRef("namirnice", n11.Id));
            o4.Namirnice.Add(new MongoDBRef("namirnice", n12.Id));

            Obrok o5 = new Obrok
            {
                Redni_Broj_Obroka = 5,
                Namirnice = new List<MongoDBRef>()
            };

            o5.Namirnice.Add(new MongoDBRef("namirnice", n13.Id));
            o5.Namirnice.Add(new MongoDBRef("namirnice", n14.Id));
            o5.Namirnice.Add(new MongoDBRef("namirnice", n15.Id));

            Obrok o6 = new Obrok
            {
                Redni_Broj_Obroka = 1,
                Namirnice = new List<MongoDBRef>()
            };

            o6.Namirnice.Add(new MongoDBRef("namirnice", n1.Id));
            o6.Namirnice.Add(new MongoDBRef("namirnice", n14.Id));
            o6.Namirnice.Add(new MongoDBRef("namirnice", n15.Id));

            Obrok o7 = new Obrok
            {
                Redni_Broj_Obroka = 2,
                Namirnice = new List<MongoDBRef>()
            };

            o7.Namirnice.Add(new MongoDBRef("namirnice", n1.Id));
            o7.Namirnice.Add(new MongoDBRef("namirnice", n4.Id));
            o7.Namirnice.Add(new MongoDBRef("namirnice", n5.Id));

            Obrok o8 = new Obrok
            {
                Redni_Broj_Obroka = 3,
                Namirnice = new List<MongoDBRef>()
            };

            o8.Namirnice.Add(new MongoDBRef("namirnice", n1.Id));
            o8.Namirnice.Add(new MongoDBRef("namirnice", n8.Id));
            o8.Namirnice.Add(new MongoDBRef("namirnice", n11.Id));

            Obrok o9 = new Obrok
            {
                Redni_Broj_Obroka = 4,
                Namirnice = new List<MongoDBRef>()
            };

            o9.Namirnice.Add(new MongoDBRef("namirnice", n1.Id));
            o9.Namirnice.Add(new MongoDBRef("namirnice", n7.Id));
            o9.Namirnice.Add(new MongoDBRef("namirnice", n9.Id));


            Obrok o10 = new Obrok
            {
                Redni_Broj_Obroka = 5,
                Namirnice = new List<MongoDBRef>()
            };

            o10.Namirnice.Add(new MongoDBRef("namirnice", n6.Id));
            o10.Namirnice.Add(new MongoDBRef("namirnice", n9.Id));
            o10.Namirnice.Add(new MongoDBRef("namirnice", n12.Id));

            Obrok o11 = new Obrok
            {
                Redni_Broj_Obroka = 1,
                Namirnice = new List<MongoDBRef>()
            };

            o11.Namirnice.Add(new MongoDBRef("namirnice", n3.Id));
            o11.Namirnice.Add(new MongoDBRef("namirnice", n6.Id));
            o11.Namirnice.Add(new MongoDBRef("namirnice", n13.Id));


            Obrok o12 = new Obrok
            {
                Redni_Broj_Obroka = 2,
                Namirnice = new List<MongoDBRef>()
            };

            o12.Namirnice.Add(new MongoDBRef("namirnice", n9.Id));
            o12.Namirnice.Add(new MongoDBRef("namirnice", n15.Id));
            o12.Namirnice.Add(new MongoDBRef("namirnice", n5.Id));

            Obrok o13 = new Obrok
            {
                Redni_Broj_Obroka = 3,
                Namirnice = new List<MongoDBRef>()
            };

            o13.Namirnice.Add(new MongoDBRef("namirnice", n10.Id));
            o13.Namirnice.Add(new MongoDBRef("namirnice", n15.Id));
            o13.Namirnice.Add(new MongoDBRef("namirnice", n3.Id));

            Obrok o14 = new Obrok
            {
                Redni_Broj_Obroka = 4,
                Namirnice = new List<MongoDBRef>()
            };

            o14.Namirnice.Add(new MongoDBRef("namirnice", n10.Id));
            o14.Namirnice.Add(new MongoDBRef("namirnice", n12.Id));
            o14.Namirnice.Add(new MongoDBRef("namirnice", n4.Id));

            Obrok o15 = new Obrok
            {
                Redni_Broj_Obroka = 5,
                Namirnice = new List<MongoDBRef>()
            };

            o15.Namirnice.Add(new MongoDBRef("namirnice", n2.Id));
            o15.Namirnice.Add(new MongoDBRef("namirnice", n14.Id));
            o15.Namirnice.Add(new MongoDBRef("namirnice", n6.Id));

            Obroci.Dodaj(o1);
            Obroci.Dodaj(o2);
            Obroci.Dodaj(o3);
            Obroci.Dodaj(o4);
            Obroci.Dodaj(o5);
            Obroci.Dodaj(o6);
            Obroci.Dodaj(o7);
            Obroci.Dodaj(o8);
            Obroci.Dodaj(o9);
            Obroci.Dodaj(o10);
            Obroci.Dodaj(o11);
            Obroci.Dodaj(o12);
            Obroci.Dodaj(o13);
            Obroci.Dodaj(o14);
            Obroci.Dodaj(o15);

            Plan_Ishrane p1 = new Plan_Ishrane()
            {
                Naziv = "Plan1",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 9.0,
                Obroci = new List<MongoDBRef>()
            };

            p1.Obroci.Add(new MongoDBRef("obroci", o1.Id));
            p1.Obroci.Add(new MongoDBRef("obroci", o2.Id));
            p1.Obroci.Add(new MongoDBRef("obroci", o3.Id));

            Plan_Ishrane p2 = new Plan_Ishrane()
            {
                Naziv = "Plan2",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 8.0,
                Obroci = new List<MongoDBRef>()
            };

            p2.Obroci.Add(new MongoDBRef("obroci", o4.Id));
            p2.Obroci.Add(new MongoDBRef("obroci", o5.Id));
            p2.Obroci.Add(new MongoDBRef("obroci", o6.Id));


            Plan_Ishrane p3 = new Plan_Ishrane()
            {
                Naziv = "Plan3",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 9.61,
                Obroci = new List<MongoDBRef>()
            };

            p3.Obroci.Add(new MongoDBRef("obroci", o7.Id));
            p3.Obroci.Add(new MongoDBRef("obroci", o8.Id));
            p3.Obroci.Add(new MongoDBRef("obroci", o9.Id));

            Plan_Ishrane p4 = new Plan_Ishrane()
            {
                Naziv = "Plan4",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 9.7,
                Obroci = new List<MongoDBRef>()
            };

            p4.Obroci.Add(new MongoDBRef("obroci", o10.Id));
            p4.Obroci.Add(new MongoDBRef("obroci", o11.Id));
            p4.Obroci.Add(new MongoDBRef("obroci", o12.Id));

            Plan_Ishrane p5 = new Plan_Ishrane()
            {
                Naziv = "Plan5",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 9.3,
                Obroci = new List<MongoDBRef>()
            };

            p5.Obroci.Add(new MongoDBRef("obroci", o13.Id));
            p5.Obroci.Add(new MongoDBRef("obroci", o14.Id));
            p5.Obroci.Add(new MongoDBRef("obroci", o15.Id));

            Plan_Ishrane p6 = new Plan_Ishrane()
            {
                Naziv = "Plan6",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 7.3,
                Obroci = new List<MongoDBRef>()
            };

            p6.Obroci.Add(new MongoDBRef("obroci", o1.Id));
            p6.Obroci.Add(new MongoDBRef("obroci", o2.Id));
            p6.Obroci.Add(new MongoDBRef("obroci", o13.Id));

            Plan_Ishrane p7 = new Plan_Ishrane()
            {
                Naziv = "Plan7",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 7.5,
                Obroci = new List<MongoDBRef>()
            };

            p7.Obroci.Add(new MongoDBRef("obroci", o11.Id));
            p7.Obroci.Add(new MongoDBRef("obroci", o7.Id));
            p7.Obroci.Add(new MongoDBRef("obroci", o6.Id));

            Plan_Ishrane p8 = new Plan_Ishrane()
            {
                Naziv = "Plan8",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 9.6,
                Obroci = new List<MongoDBRef>()
            };

            p8.Obroci.Add(new MongoDBRef("obroci", o3.Id));
            p8.Obroci.Add(new MongoDBRef("obroci", o14.Id));
            p8.Obroci.Add(new MongoDBRef("obroci", o1.Id));

            Plan_Ishrane p9 = new Plan_Ishrane()
            {
                Naziv = "Plan98",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 8.1,
                Obroci = new List<MongoDBRef>()
            };

            p9.Obroci.Add(new MongoDBRef("obroci", o13.Id));
            p9.Obroci.Add(new MongoDBRef("obroci", o12.Id));
            p9.Obroci.Add(new MongoDBRef("obroci", o3.Id));

            Plan_Ishrane p10 = new Plan_Ishrane()
            {
                Naziv = "Plan10",
                Broj_Ocenjivanja = 0,
                Prosecna_Ocena = 6,
                Obroci = new List<MongoDBRef>()
            };

            p10.Obroci.Add(new MongoDBRef("obroci", o14.Id));
            p10.Obroci.Add(new MongoDBRef("obroci", o11.Id));
            p10.Obroci.Add(new MongoDBRef("obroci", o6.Id));

            PlanIshrane.Dodaj(p1);
            PlanIshrane.Dodaj(p2);
            PlanIshrane.Dodaj(p3);
            PlanIshrane.Dodaj(p4);
            PlanIshrane.Dodaj(p5);
            PlanIshrane.Dodaj(p6);
            PlanIshrane.Dodaj(p7);
            PlanIshrane.Dodaj(p8);
            PlanIshrane.Dodaj(p9);
            PlanIshrane.Dodaj(p10);



            //treninzi
            Trening t1 = new Trening()
            {
                Naziv = "Trening1",
                Misicna_Partija = "abs",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Vezbe = new List<MongoDBRef>()
            };
            t1.Vezbe.Add(new MongoDBRef("vezbe", v1.Id));
            t1.Vezbe.Add(new MongoDBRef("vezbe", v2.Id));
            Treninzi.Dodaj(t1);

            Trening t2 = new Trening()
            {
                Naziv = "Trening2",
                Misicna_Partija = "back",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Vezbe = new List<MongoDBRef>()
            };
            t2.Vezbe.Add(new MongoDBRef("vezbe", v3.Id));
            t2.Vezbe.Add(new MongoDBRef("vezbe", v4.Id));
            Treninzi.Dodaj(t2);

            Trening t3 = new Trening()
            {
                Naziv = "Trening3",
                Misicna_Partija = "biceps",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Vezbe = new List<MongoDBRef>()
            };
            t3.Vezbe.Add(new MongoDBRef("vezbe", v5.Id));
            t3.Vezbe.Add(new MongoDBRef("vezbe", v6.Id));
            Treninzi.Dodaj(t3);

            Trening t4 = new Trening()
            {
                Naziv = "Trening4",
                Misicna_Partija = "chest",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Vezbe = new List<MongoDBRef>()
            };
            t4.Vezbe.Add(new MongoDBRef("vezbe", v7.Id));
            t4.Vezbe.Add(new MongoDBRef("vezbe", v8.Id));
            Treninzi.Dodaj(t4);

            Trening t5 = new Trening()
            {
                Naziv = "Trening5",
                Misicna_Partija = "legs",
                Prosecna_Ocena = 9.0f,
                Broj_Ocenjivanja = 0,
                Vezbe = new List<MongoDBRef>()
            };
            t5.Vezbe.Add(new MongoDBRef("vezbe", v9.Id));
            t5.Vezbe.Add(new MongoDBRef("vezbe", v10.Id));
            Treninzi.Dodaj(t5);









            k1.Planovi_Ishrane = new List<MongoDBRef>();
            k1.Treninzi = new List<MongoDBRef>();

            k2.Planovi_Ishrane = new List<MongoDBRef>();
            k2.Treninzi = new List<MongoDBRef>();

            k3.Planovi_Ishrane = new List<MongoDBRef>();
            k3.Treninzi = new List<MongoDBRef>();

            k4.Planovi_Ishrane = new List<MongoDBRef>();
            k4.Treninzi = new List<MongoDBRef>();

            k5.Planovi_Ishrane = new List<MongoDBRef>();
            k5.Treninzi = new List<MongoDBRef>();

            k6.Planovi_Ishrane = new List<MongoDBRef>();
            k6.Treninzi = new List<MongoDBRef>();

            k4.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p1.Id));
            k4.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p2.Id));
            k4.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p3.Id));
            k4.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p4.Id));
            k4.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p5.Id));

            k5.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p6.Id));
            k5.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p7.Id));
            k5.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p8.Id));
            k5.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p9.Id));
            k5.Planovi_Ishrane.Add(new MongoDBRef("planovi_ishrane", p10.Id));

            k4.Treninzi.Add(new MongoDBRef("treninzi", t1.Id));
            k4.Treninzi.Add(new MongoDBRef("treninzi", t2.Id));
            k4.Treninzi.Add(new MongoDBRef("treninzi", t3.Id));

            k5.Treninzi.Add(new MongoDBRef("treninzi", t4.Id));
            k5.Treninzi.Add(new MongoDBRef("treninzi", t5.Id));

            var collection = Connection<Korisnik>.getCollection("korisnici");
            collection.Save(k4);
            collection.Save(k5);

            //poruke

            Poruka m1 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k3.Id),
                Receiver_ID = new MongoDBRef("korisnici", k4.Id)
            };

            Poruka m2 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k4.Id),
                Receiver_ID = new MongoDBRef("korisnici", k3.Id)
            };

            Poruka m3 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k3.Id),
                Receiver_ID = new MongoDBRef("korisnici", k4.Id)
            };


            Poruka m4 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k4.Id),
                Receiver_ID = new MongoDBRef("korisnici", k3.Id)
            };

            Poruka m5 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k3.Id),
                Receiver_ID = new MongoDBRef("korisnici", k5.Id)
            };

            Poruka m6 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k5.Id),
                Receiver_ID = new MongoDBRef("korisnici", k3.Id)
            };

            Poruka m7 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k3.Id),
                Receiver_ID = new MongoDBRef("korisnici", k5.Id)
            };


            Poruka m8 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k5.Id),
                Receiver_ID = new MongoDBRef("korisnici", k3.Id)
            };

            Poruka m9 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k6.Id),
                Receiver_ID = new MongoDBRef("korisnici", k4.Id)
            };

            Poruka m10 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k4.Id),
                Receiver_ID = new MongoDBRef("korisnici", k6.Id)
            };

            Poruka m11 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k6.Id),
                Receiver_ID = new MongoDBRef("korisnici", k4.Id)
            };


            Poruka m12 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k4.Id),
                Receiver_ID = new MongoDBRef("korisnici", k6.Id)
            };

            Poruka m13 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k6.Id),
                Receiver_ID = new MongoDBRef("korisnici", k5.Id)
            };

            Poruka m14 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k5.Id),
                Receiver_ID = new MongoDBRef("korisnici", k6.Id)
            };

            Poruka m15 = new Poruka
            {
                Procitana = false,
                Tekst = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k6.Id),
                Receiver_ID = new MongoDBRef("korisnici", k5.Id)
            };


            Poruka m16 = new Poruka
            {
                Procitana = false,
                Tekst = "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Vreme_Slanja = DateTime.Now,
                Sender_ID = new MongoDBRef("korisnici", k5.Id),
                Receiver_ID = new MongoDBRef("korisnici", k6.Id)
            };

            Poruke.Dodaj(m1);
            Poruke.Dodaj(m2);
            Poruke.Dodaj(m3);
            Poruke.Dodaj(m4);
            Poruke.Dodaj(m5);
            Poruke.Dodaj(m6);
            Poruke.Dodaj(m7);
            Poruke.Dodaj(m8);
            Poruke.Dodaj(m9);
            Poruke.Dodaj(m10);
            Poruke.Dodaj(m11);
            Poruke.Dodaj(m12);
            Poruke.Dodaj(m13);
            Poruke.Dodaj(m14);
            Poruke.Dodaj(m15);
            Poruke.Dodaj(m16);




        }
 
    }
}
