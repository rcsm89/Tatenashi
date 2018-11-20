﻿// <auto-generated />
using Justibot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace justibot_server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20171105053302_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Justibot.admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("staffMember");

                    b.HasKey("adminId");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("Justibot.blacklist", b =>
                {
                    b.Property<int>("blacklistID")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("bserver");

                    b.HasKey("blacklistID");

                    b.ToTable("blacklists");
                });

            modelBuilder.Entity("Justibot.Entry", b =>
                {
                    b.Property<int>("EntryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GiveawayId");

                    b.Property<ulong>("entrentID");

                    b.Property<bool>("ishost");

                    b.HasKey("EntryID");

                    b.HasIndex("GiveawayId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("Justibot.Giveaway", b =>
                {
                    b.Property<int>("GiveawayId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("GActive");

                    b.Property<ulong>("Gchannel");

                    b.Property<ulong>("GservID");

                    b.Property<string>("prize");

                    b.HasKey("GiveawayId");

                    b.ToTable("Givaways");
                });

            modelBuilder.Entity("Justibot.globaluserxp", b =>
                {
                    b.Property<int>("globaluserxpID")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("User");

                    b.Property<int>("Xp");

                    b.HasKey("globaluserxpID");

                    b.ToTable("globalusersxp");
                });

            modelBuilder.Entity("Justibot.LeavingMessage", b =>
                {
                    b.Property<int>("LeavingMessageID")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("leavingGuild");

                    b.Property<string>("message");

                    b.HasKey("LeavingMessageID");

                    b.ToTable("leavingMessages");
                });

            modelBuilder.Entity("Justibot.music", b =>
                {
                    b.Property<int>("musicId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tname");

                    b.Property<ulong>("Tserver");

                    b.HasKey("musicId");

                    b.ToTable("musics");
                });

            modelBuilder.Entity("Justibot.Note", b =>
                {
                    b.Property<int>("NoteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.Property<ulong>("User");

                    b.Property<ulong>("nServId");

                    b.HasKey("NoteID");

                    b.ToTable("notes");
                });

            modelBuilder.Entity("Justibot.reward", b =>
                {
                    b.Property<int>("rewardID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("rewardlvl");

                    b.Property<ulong>("rewardrole");

                    b.Property<ulong>("rserver");

                    b.HasKey("rewardID");

                    b.ToTable("rewards");
                });

            modelBuilder.Entity("Justibot.ServerPerm", b =>
                {
                    b.Property<int>("ServerPermID")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("PServId");

                    b.Property<bool>("PermActive");

                    b.Property<ulong>("PermArg");

                    b.Property<string>("Pmode");

                    b.Property<string>("SPerm");

                    b.HasKey("ServerPermID");

                    b.ToTable("ServerPerms");
                });

            modelBuilder.Entity("Justibot.serveruserxp", b =>
                {
                    b.Property<int>("serveruserxpID")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("User");

                    b.Property<int>("Xp");

                    b.Property<int?>("serverxpID");

                    b.HasKey("serveruserxpID");

                    b.HasIndex("serverxpID");

                    b.ToTable("serverusersxp");
                });

            modelBuilder.Entity("Justibot.serverxp", b =>
                {
                    b.Property<int>("serverxpID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Xp");

                    b.Property<ulong>("xServId");

                    b.HasKey("serverxpID");

                    b.ToTable("serversxp");
                });

            modelBuilder.Entity("Justibot.ServPrefix", b =>
                {
                    b.Property<int>("ServPrefixID")
                        .ValueGeneratedOnAdd();

                    b.Property<char>("prefix");

                    b.Property<ulong>("prefixGuild");

                    b.HasKey("ServPrefixID");

                    b.ToTable("prefixes");
                });

            modelBuilder.Entity("Justibot.staffRole", b =>
                {
                    b.Property<int>("staffRoleID")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("PermArg");

                    b.Property<ulong>("RServId");

                    b.HasKey("staffRoleID");

                    b.ToTable("staffRoles");
                });

            modelBuilder.Entity("Justibot.Tmatch", b =>
                {
                    b.Property<int>("TmatchID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Tmatchno");

                    b.Property<int?>("TournamentId");

                    b.Property<int>("Troundno");

                    b.Property<int>("Tteam1ID");

                    b.Property<int>("Tteam2ID");

                    b.HasKey("TmatchID");

                    b.HasIndex("TournamentId");

                    b.ToTable("TMatches");
                });

            modelBuilder.Entity("Justibot.Tournament", b =>
                {
                    b.Property<int>("TournamentId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Tactive");

                    b.Property<ulong>("Tchannel");

                    b.Property<ulong>("Thost");

                    b.Property<string>("Title");

                    b.Property<int>("Tmax");

                    b.Property<ulong>("TservID");

                    b.Property<bool>("joinable");

                    b.HasKey("TournamentId");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("Justibot.TPlayer", b =>
                {
                    b.Property<int>("TPlayerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TournamentId");

                    b.Property<bool>("isLeader");

                    b.Property<bool>("lost");

                    b.Property<ulong>("playerID");

                    b.Property<int>("state");

                    b.Property<int>("teamNo");

                    b.HasKey("TPlayerID");

                    b.HasIndex("TournamentId");

                    b.ToTable("TPlayers");
                });

            modelBuilder.Entity("Justibot.versionControl", b =>
                {
                    b.Property<int>("versionControlID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("time");

                    b.Property<string>("version");

                    b.HasKey("versionControlID");

                    b.ToTable("versionChecks");
                });

            modelBuilder.Entity("Justibot.WelcomeMessage", b =>
                {
                    b.Property<int>("WelcomeMessageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("message");

                    b.Property<ulong>("welcomeGuild");

                    b.HasKey("WelcomeMessageID");

                    b.ToTable("welcomeMessages");
                });

            modelBuilder.Entity("Justibot.Entry", b =>
                {
                    b.HasOne("Justibot.Giveaway", "Giveaway")
                        .WithMany("Entries")
                        .HasForeignKey("GiveawayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Justibot.serveruserxp", b =>
                {
                    b.HasOne("Justibot.serverxp", "Server")
                        .WithMany("usersXp")
                        .HasForeignKey("serverxpID");
                });

            modelBuilder.Entity("Justibot.Tmatch", b =>
                {
                    b.HasOne("Justibot.Tournament", "Tournament")
                        .WithMany("matches")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("Justibot.TPlayer", b =>
                {
                    b.HasOne("Justibot.Tournament", "Tournament")
                        .WithMany("players")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}