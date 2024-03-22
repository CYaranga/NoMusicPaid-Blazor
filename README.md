# NoMusicPaid: A Thesis Project for a Music Production Degree
NoMusicPaid is a culmination of a music production degree, showcasing the integration of various technologies to create a unique and interactive music experience. The project provides access to a library of music free of rights, allowing users to explore and utilize a wide range of tracks for their creative endeavors.

This project has been shutdown since the changes in Firebase hosting that doesn't allow me any more to deploy using the spark plan


## Technologies Used

1. **Blazor WebAssembly**: This project is built using Blazor WebAssembly, a single-page app framework for building interactive client-side web apps with .NET.

2. **CSVHelper**: This library is used for reading and writing CSV files, which are used to store and manage data related to music tracks.

3. **Firebase**: Firebase is used for hosting the application, ensuring a seamless deployment and distribution process.

4. **GitHub Actions**: This project uses GitHub Actions for continuous integration and deployment, automating the process of deploying the application to Firebase.

5. **MudBlazor**: This is a popular UI component library for Blazor applications. It provides a variety of pre-built components that have been used to create the user interface of this application.

## Project Structure

The project is structured into various directories, each serving a specific purpose:

- [`src`](command:_github.copilot.openRelativePath?%5B%22src%22%5D "src"): Contains the source code of the application.
- [`src/Data`](command:_github.copilot.openRelativePath?%5B%22src%2FData%22%5D "src/Data"): Contains classes related to data handling and manipulation.
- [`src/Components`](command:_github.copilot.openRelativePath?%5B%22src%2FComponents%22%5D "src/Components"): Contains reusable components used across the application.
- [`src/Pages`](command:_github.copilot.openRelativePath?%5B%22src%2FPages%22%5D "src/Pages"): Contains the different pages of the application.
- [`public`](command:_github.copilot.openRelativePath?%5B%22public%22%5D "public"): Contains static files like `index.html`.
- [`.github/workflows`](command:_github.copilot.openRelativePath?%5B%22.github%2Fworkflows%22%5D ".github/workflows"): Contains workflow files for GitHub Actions.

## Building the Project

To build this project, you need to have .NET 7.0 SDK installed. Once installed, navigate to the project directory and run the following command:

```sh
dotnet build
```

This will compile the project and create a bin directory with the compiled output.

## Running the Project
To run the project, navigate to the project directory and run the following command:

This will start the application and it will be accessible at https://localhost:5001.

## Conclusion
NoMusicPaid serves as a testament to the skills and knowledge acquired over the course of a music production degree. It showcases the power of modern web technologies in creating interactive and engaging experiences, while providing a valuable resource of royalty-free music.
