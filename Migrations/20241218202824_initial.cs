using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project5.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    contentType = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReviewerName = table.Column<string>(type: "TEXT", nullable: false),
                    ReviewTitle = table.Column<string>(type: "TEXT", nullable: false),
                    ReviewDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContentID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentCategories_Content_ContentID",
                        column: x => x.ContentID,
                        principalTable: "Content",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Fantasy transports viewers to magical realms filled with mythical creatures, extraordinary powers, and enchanting worlds. This genre explores themes of wonder, imagination, and the battle between light and darkness, often emphasizing the limitless possibilities of the unknown.", "Fantasy" },
                    { 2L, "Adventure centers on thrilling journeys, quests, and explorations. Characters embark on daring missions, often venturing into uncharted territories and facing obstacles that test their courage and resourcefulness. These stories celebrate bravery, discovery, and perseverance.", "Adventure" },
                    { 3L, "Action is characterized by high-energy sequences, intense physical conflict, and fast-paced storytelling. This genre emphasizes dynamic battles, daring rescues, and feats of heroism. It keeps viewers on the edge of their seats with its focus on adrenaline-fueled moments and powerful confrontations.", "Action" },
                    { 4L, "Romance delves into the complexities of love and relationships, often focusing on the emotional journeys of its characters. It highlights themes of connection, passion, and the challenges of love, offering heartwarming or bittersweet narratives.", "Romance" },
                    { 5L, "Historical films transport viewers to specific time periods, offering a glimpse into the culture, events, and lives of people in the past. This genre often explores how history shapes individuals and communities, blending rich settings with thought-provoking storytelling.", "Historical" },
                    { 6L, "Drama focuses on deep emotional storytelling, highlighting the personal and interpersonal struggles of its characters. This genre often tackles themes of love, loss, ambition, and morality, providing a window into human experiences and emotions.", "Drama" },
                    { 7L, "Sci-Fi (Science Fiction) explores speculative and futuristic concepts, often set in space, on other planets, or in alternate realities. It delves into advanced technology, space travel, time travel, and the potential consequences of scientific advancements, allowing viewers to imagine a future shaped by new discoveries and challenges.", "Sci-Fi" },
                    { 8L, "Thriller is a genre that focuses on suspense, tension, and excitement, keeping the audience on the edge of their seat. It often involves high-stakes situations, danger, and unexpected twists, with a strong emphasis on keeping viewers in suspense as characters navigate through moments of peril.", "Thriller" },
                    { 9L, "Crime stories focus on illegal activities, law enforcement, and the moral complexities surrounding crime and justice. It often involves criminals, detectives, and investigations, with a strong emphasis on uncovering truths, solving mysteries, and dealing with the consequences of criminal actions.", "Crime" },
                    { 10L, "Comedy is all about humor, wit, and entertainment. It features lighthearted situations, funny characters, and amusing dialogues designed to make the audience laugh. Whether through slapstick, satire, or situational humor, comedy explores the lighter side of life and often portrays characters in exaggerated or absurd situations.", "Comedy" },
                    { 11L, "Biography focuses on the lives of real people, telling the stories of their achievements, challenges, and lasting impacts. It often delves into the personal and professional experiences of notable individuals, exploring their journey and how they shaped history or their respective fields.", "Biography" },
                    { 12L, "Horror is designed to elicit fear and suspense in its audience. This genre focuses on the supernatural, grotesque, and terrifying, often involving monsters, ghosts, or otherworldly beings. It aims to unsettle and scare viewers with dark, eerie atmospheres and unexpected shocks.", "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "contentType" },
                values: new object[,]
                {
                    { 1, "My Neighbor Totoro is a heartwarming story about two young sisters who move to the countryside and discover magical creatures, including the lovable and giant Totoro. The film explores themes of childhood wonder, innocence, and the beauty of nature.", "/images/totoro.png", new DateTime(1988, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "My Neighbor Totoro", "Anime" },
                    { 2, "Spirited Away follows Chihiro, a young girl who, while traveling with her parents, stumbles into a mysterious world of spirits and gods. As her parents are transformed into pigs, Chihiro must work in a bathhouse to find a way to escape and return to her world.", "/images/spiritedaway.png", new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away", "Anime" },
                    { 3, "Princess Mononoke tells the story of Ashitaka, a young man caught in the battle between the forest gods and human industry. As he tries to find a cure for a curse, he encounters the fierce warrior Princess Mononoke, who has a deep bond with the forest spirits.", "/images/mononoke.png", new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Princess Mononoke", "Anime" },
                    { 4, "Howl's Moving Castle follows Sophie, a young woman who is cursed by a witch to take the form of an old woman. She seeks refuge in the magical, moving castle of the mysterious wizard Howl, and together they embark on an adventure that blends love, war, and transformation.", "/images/howlsmovingcastle.png", new DateTime(2004, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Howl's Moving Castle", "Anime" },
                    { 5, "Kiki's Delivery Service is about a young witch named Kiki who sets out to find her place in the world. She opens a flying delivery service in a coastal town, and the film explores themes of independence, self-discovery, and growing up.", "/images/kiki.png", new DateTime(1989, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiki's Delivery Service", "Anime" },
                    { 6, "The Wind Rises is a fictionalized biography of Jiro Horikoshi, the engineer who designed the Mitsubishi A6M Zero fighter plane during World War II. The film explores Jiro's passion for aviation and his love story with Naoko, as well as the moral dilemmas posed by the destructive power of war.", "/images/thewindrises.png", new DateTime(2013, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wind Rises", "Anime" },
                    { 7, "Ponyo is a fantasy film about a young fish-girl who becomes human after befriending a boy named Sosuke. The film follows their adventure as the sea and the land merge in a magical journey of love and environmental themes.", "/images/ponyo.png", new DateTime(2008, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ponyo", "Anime" },
                    { 8, "The Shawshank Redemption is a powerful drama about hope and friendship, following Andy Dufresne, a banker wrongfully imprisoned for the murder of his wife. Over the decades, Andy forms a deep bond with fellow inmate Ellis 'Red' Redding while navigating the harsh realities of Shawshank prison. The film explores themes of resilience, redemption, and the transformative power of hope. It’s a poignant tale of enduring friendship and the possibility of freedom, even in the most oppressive circumstances.", "/images/theshawshank.png", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption", "Movie" },
                    { 21, "Batman faces his most formidable foe, the Joker, a criminal mastermind who seeks to create chaos in Gotham City. The film explores themes of morality, justice, and the consequences of vigilantism. Known for its complex characters, stunning visuals, and a breathtaking performance by Heath Ledger as the Joker, The Dark Knight is regarded as one of the greatest superhero films ever made.", "/images/darkknight.png", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight", "Movie" },
                    { 22, "The Godfather follows the powerful Corleone family as they navigate the world of organized crime. Vito Corleone, the patriarch, struggles to keep his family intact while passing the torch to his reluctant son, Michael. The film explores themes of power, loyalty, and corruption, and is widely considered one of the greatest films in cinematic history.", "/images/godfather.png", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather", "Movie" },
                    { 23, "Forrest Gump is a heartwarming story of a man with a low IQ who unwittingly influences major events in American history, all while falling in love with his childhood sweetheart, Jenny. The film combines comedy, drama, and historical moments to tell a tale of perseverance, love, and fate.", "/images/forrestgump.png", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", "Movie" },
                    { 24, "The Matrix is a sci-fi thriller that follows Neo, a hacker who learns that the reality he lives in is a simulated illusion created by machines to subjugate humanity. With the help of a group of rebels, Neo must fight to free humankind from the Matrix and uncover the truth about his role in the revolution.", "/images/matrix.png", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix", "Movie" },
                    { 25, "Pulp Fiction tells multiple interwoven stories involving crime, redemption, and unexpected violence. Through characters like hitmen Vincent Vega and Jules Winnfield, director Quentin Tarantino crafts a film filled with sharp dialogue, nonlinear storytelling, and iconic scenes. It is a cult classic that redefined modern cinema.", "/images/pulpfiction.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction", "Movie" },
                    { 26, "Fight Club explores the psyche of an unnamed protagonist who, dissatisfied with his life, forms an underground fight club as a way to reclaim his identity. As the club's philosophy grows into a dangerous, anarchistic movement, the protagonist grapples with his own mental breakdown.", "/images/fightclub.png", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club", "Movie" },
                    { 27, "Schindler's List tells the true story of Oskar Schindler, a German businessman who saved over a thousand Jewish lives during the Holocaust. This powerful and poignant film explores the horrors of the genocide while highlighting the impact one person can have in the face of unimaginable evil.", "/images/sch.png", new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List", "Movie" },
                    { 28, "Inception is a mind-bending thriller directed by Christopher Nolan, following Dom Cobb, a skilled thief who enters people's dreams to steal secrets. He is tasked with a challenging mission to plant an idea in someone’s mind, a process known as 'inception'. As Cobb faces personal demons, the line between reality and dreams blurs, creating a layered narrative of suspense, action, and philosophical exploration about perception, memory, and the subconscious.", "/images/inception.png", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", "Movie" },
                    { 29, "Interstellar follows a group of astronauts who travel through a wormhole in search of a new habitable planet for humanity. The film explores themes of love, sacrifice, and the survival of the human race, all within a stunning visual representation of space and time.", "/images/interstellar.png", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar", "Movie" },
                    { 30, "The Revenant follows frontiersman Hugh Glass, who is left for dead after being mauled by a bear. The film portrays his brutal journey of survival and quest for revenge, highlighting themes of human resilience, nature's brutality, and the will to live.", "/images/revenant.png", new DateTime(2015, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Revenant", "Movie" },
                    { 31, "Breaking Bad follows Walter White, a high school chemistry teacher turned methamphetamine manufacturer, as he descends into the criminal underworld. The series explores themes of morality, power, and transformation, and is regarded as one of the greatest TV shows of all time.", "/images/breakingbad.png", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", "Series" },
                    { 32, "Stranger Things is a supernatural thriller set in the 1980s, revolving around a group of kids who uncover a dark secret about their town, Hawkins. The series blends horror, sci-fi, and heartwarming friendship as they face off against a parallel dimension called the Upside Down.", "/images/strang.png", new DateTime(2016, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stranger Things", "Series" },
                    { 33, "The Crown chronicles the reign of Queen Elizabeth II, exploring the political and personal challenges she faces as the leader of the British Empire. The series delves into the relationships, conflicts, and historical events that shaped her reign and the monarchy.", "/images/crown.png", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Crown", "Series" },
                    { 34, "Dark is a German sci-fi thriller that explores time travel, fate, and the interconnections between four families in the small town of Winden. As characters travel across different timelines, they uncover paradoxes, revealing that the past, present, and future are inextricably linked.", "/images/dark.png", new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark", "Series" },
                    { 35, "Game of Thrones is an epic fantasy series set in the fictional continents of Westeros and Essos. The show follows several noble families as they vie for control of the Iron Throne, all while a looming supernatural threat in the form of the White Walkers grows stronger.", "/images/game.png", new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", "Series" },
                    { 36, "The Mandalorian is a Star Wars spin-off that follows a lone bounty hunter in the outer reaches of the galaxy. As he navigates a dangerous world, he encounters a mysterious Force-sensitive child, Baby Yoda, and becomes embroiled in a larger conflict.", "/images/manda.png", new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mandalorian", "Series" },
                    { 37, "Peaky Blinders follows the Shelby crime family in post-World War I Birmingham, England. Led by the ambitious and ruthless Tommy Shelby, the family navigates the dangerous world of organized crime, politics, and family loyalty.", "/images/peaky.png", new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaky Blinders", "Series" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Rating", "ReviewDescription", "ReviewTitle", "ReviewerName" },
                values: new object[,]
                {
                    { 1L, 5, "Test description", "Test title", "Test" },
                    { 2L, 4, "Test description1", "Test title1", "Test1" },
                    { 3L, 3, "Test description2", "Test title2", "Test2" },
                    { 4L, 2, "Test description3", "Test title3", "Test3" }
                });

            migrationBuilder.InsertData(
                table: "ContentCategories",
                columns: new[] { "Id", "CategoryID", "ContentID" },
                values: new object[,]
                {
                    { 1, 8L, 7 },
                    { 2, 7L, 7 },
                    { 3, 3L, 21 },
                    { 4, 8L, 21 },
                    { 5, 9L, 22 },
                    { 6, 6L, 22 },
                    { 7, 6L, 23 },
                    { 8, 10L, 23 },
                    { 9, 7L, 24 },
                    { 10, 3L, 24 },
                    { 11, 9L, 25 },
                    { 12, 6L, 25 },
                    { 13, 6L, 26 },
                    { 14, 5L, 27 },
                    { 15, 6L, 27 },
                    { 16, 7L, 28 },
                    { 17, 8L, 28 },
                    { 18, 7L, 29 },
                    { 19, 2L, 29 },
                    { 20, 2L, 30 },
                    { 21, 6L, 30 },
                    { 22, 9L, 31 },
                    { 23, 6L, 31 },
                    { 24, 7L, 32 },
                    { 25, 12L, 32 },
                    { 26, 11L, 33 },
                    { 27, 6L, 33 },
                    { 28, 7L, 34 },
                    { 29, 8L, 34 },
                    { 30, 1L, 35 },
                    { 31, 6L, 35 },
                    { 32, 7L, 36 },
                    { 33, 3L, 36 },
                    { 34, 9L, 37 },
                    { 35, 6L, 37 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentCategories_CategoryID",
                table: "ContentCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCategories_ContentID",
                table: "ContentCategories",
                column: "ContentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentCategories");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Content");
        }
    }
}
