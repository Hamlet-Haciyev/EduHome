USE [EduHome]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'185d58cc-05f4-4670-a1a0-9b142bf4bb3f', N'Admin', N'ADMIN', N'e0456cb4-df6f-4429-bd8b-93a68ca12627')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3f935dbc-6b10-4b3c-9ed0-17fd56916f99', N'Moderator', N'MODERATOR', N'9bcb81f6-c5af-4e87-8e09-44200f852a46')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a9e45b2d-a947-42d0-9c6d-3063499b081e', N'User', N'USER', N'31bc2fae-648f-4f0e-8795-2606ec8ca3f0')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Image], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9707322b-13c9-4ee5-8900-021509286940', N'CustomUser', NULL, N'Hamlet2', N'Haciyev', CAST(N'2021-12-15T21:55:12.0771055' AS DateTime2), N'hamilet76@gmail.com', N'HAMILET76@GMAIL.COM', N'hamilet76@gmail.com', N'HAMILET76@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEC3d6kuw8CcrouflTsmnJ/5rQd/6ePC+WfHLj7ZHiHrBeXBgQJq2fBj7vo2B2k9p9w==', N'UQLE3YGRDL5QBBRJNU2T2S6WA25YBIGO', N'2fab2099-02c7-4007-883d-4da2f3c464d7', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Image], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c1239877-fe7c-49ff-b41a-e9ecdbfb3215', N'CustomUser', NULL, N'Hamlet', N'Haciyev', CAST(N'2021-12-15T08:19:11.7372834' AS DateTime2), N'hamilet75@gmail.com', N'HAMILET75@GMAIL.COM', N'hamilet75@gmail.com', N'HAMILET75@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEK3oiZWtSZkWq2L25Jd2Liyhntp7WVILXAQECmYi1kyxArZZ/EkfcJam3tK+Ax00Uw==', N'UEVXJ4GHJHV7OERATJNOF2KKMZ3RRP34', N'ee9b7a38-4495-40b2-a1cb-10f9463a0f20', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9707322b-13c9-4ee5-8900-021509286940', N'185d58cc-05f4-4670-a1a0-9b142bf4bb3f')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c1239877-fe7c-49ff-b41a-e9ecdbfb3215', N'a9e45b2d-a947-42d0-9c6d-3063499b081e')
GO
SET IDENTITY_INSERT [dbo].[Hobbies] ON 

INSERT [dbo].[Hobbies] ([Id], [Name]) VALUES (1, N'music')
INSERT [dbo].[Hobbies] ([Id], [Name]) VALUES (2, N'travelling')
INSERT [dbo].[Hobbies] ([Id], [Name]) VALUES (3, N'catching fish')
SET IDENTITY_INSERT [dbo].[Hobbies] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (1, N'STUART KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher-details.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (3, N'LUIS KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher2.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (4, N'LEOKELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher3.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (5, N'CRISTIANOKELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher4.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (6, N'ANNA KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher5.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (7, N'STUART KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher6.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (8, N'JACK KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher7.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (9, N'LEONARDO KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher8.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (10, N'STUART KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher9.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (11, N'STUART KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher10.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (12, N'STUART KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'Din, Department of Micro Biology', N'stuart@eduhome.com', N'(+125) 5896 548 9874', N'stuart.k', N'teacher11.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (13, N'Hamlet', N'Developer', N'asdddddddd', N'Senior', N'7 Years', N'IT', N'hamilet75@gmail.com', N'055-366-11-01', N'asdasd', N'11262c2f-11e6-4869-9f21-8fe165b205be-20211213233630-teacher3.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Position], [About], [Degree], [Experience], [Faculty], [Mail], [Phone], [Skype], [Image]) VALUES (15, N'Hamlet', N'Web Developer', N'asdaksvdlavhkasdvklvskfavksfklvasfvffahvfavhafvhahaffahvlhvlfshl5', N'Senior', N'3 Years', N'IT', N'hamilet75@gmail.com', N'055-366-11-01', N'asdasd', N'7e333edd-fc3d-4d85-935d-116589e892d6-20211215083103-teacher8.jpg')
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher_Hobbies] ON 

INSERT [dbo].[Teacher_Hobbies] ([Id], [Hobbie_Id], [Teacher_Id]) VALUES (1, 1, 1)
INSERT [dbo].[Teacher_Hobbies] ([Id], [Hobbie_Id], [Teacher_Id]) VALUES (2, 2, 1)
INSERT [dbo].[Teacher_Hobbies] ([Id], [Hobbie_Id], [Teacher_Id]) VALUES (3, 3, 1)
INSERT [dbo].[Teacher_Hobbies] ([Id], [Hobbie_Id], [Teacher_Id]) VALUES (20, 1, 15)
INSERT [dbo].[Teacher_Hobbies] ([Id], [Hobbie_Id], [Teacher_Id]) VALUES (21, 3, 15)
SET IDENTITY_INSERT [dbo].[Teacher_Hobbies] OFF
GO
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([Id], [Name]) VALUES (5, N'Language')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (6, N'Team Leader')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (7, N'Development')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (8, N'Design')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (9, N'Innovation')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (10, N'Communication')
SET IDENTITY_INSERT [dbo].[Skills] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher_Skills] ON 

INSERT [dbo].[Teacher_Skills] ([Id], [Skill_Id], [Teacher_Id], [Percent]) VALUES (2, 5, 1, 85)
INSERT [dbo].[Teacher_Skills] ([Id], [Skill_Id], [Teacher_Id], [Percent]) VALUES (3, 6, 1, 90)
INSERT [dbo].[Teacher_Skills] ([Id], [Skill_Id], [Teacher_Id], [Percent]) VALUES (4, 7, 1, 85)
INSERT [dbo].[Teacher_Skills] ([Id], [Skill_Id], [Teacher_Id], [Percent]) VALUES (5, 8, 1, 95)
INSERT [dbo].[Teacher_Skills] ([Id], [Skill_Id], [Teacher_Id], [Percent]) VALUES (6, 9, 1, 85)
INSERT [dbo].[Teacher_Skills] ([Id], [Skill_Id], [Teacher_Id], [Percent]) VALUES (7, 10, 1, 95)
SET IDENTITY_INSERT [dbo].[Teacher_Skills] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher_Socials] ON 

INSERT [dbo].[Teacher_Socials] ([Id], [Name], [Icon]) VALUES (1, N'Facebook', N'fab fa-facebook-f')
INSERT [dbo].[Teacher_Socials] ([Id], [Name], [Icon]) VALUES (2, N'Pinterest', N'fab fa-pinterest')
INSERT [dbo].[Teacher_Socials] ([Id], [Name], [Icon]) VALUES (3, N'Whatsapp', N'fab fa-vimeo')
INSERT [dbo].[Teacher_Socials] ([Id], [Name], [Icon]) VALUES (4, N'Twitter', N'fab fa-twitter')
SET IDENTITY_INSERT [dbo].[Teacher_Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[TeacherToSocials] ON 

INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (1, 1, 1, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (2, 2, 1, N'https://web.whatsapp.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (3, 3, 1, N'https://www.instagram.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (4, 4, 1, N'https://twitter.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (10, 1, 3, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (11, 2, 3, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (12, 3, 3, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (13, 4, 3, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (14, 1, 4, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (15, 2, 4, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (16, 3, 4, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (17, 4, 4, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (18, 1, 5, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (19, 2, 5, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (20, 3, 5, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (21, 4, 5, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (22, 1, 6, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (23, 2, 6, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (24, 3, 6, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (25, 4, 6, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (26, 1, 7, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (27, 2, 7, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (28, 3, 7, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (29, 4, 7, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (30, 1, 8, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (31, 2, 8, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (32, 3, 8, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (33, 4, 8, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (34, 1, 9, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (35, 2, 9, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (36, 3, 9, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (37, 4, 9, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (38, 1, 10, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (39, 2, 10, N'https://www.facebook.com/')
INSERT [dbo].[TeacherToSocials] ([Id], [Teacher_Social_Id], [Teacher_Id], [Link]) VALUES (40, 3, 10, N'https://www.facebook.com/')
SET IDENTITY_INSERT [dbo].[TeacherToSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (1, N'Teacher / Details', N'TeacherDetails')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (2, N'Courses / Detail', N'CourseDetail')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (3, N'Event / Deatils', N'EventDetails')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (8, N'Blog / Details', N'BlogDetails')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
