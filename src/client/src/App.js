import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';

class App extends Component {

  constructor(props) {
    super(props);
    this.state = {
      book: {
        id: 0,
        name: '',
        author: '',
        publishDate: '',
        purchaseDate: ''
      }
    }
  }

  async componentDidMount() {
    const book = await axios.get('http://localhost:50350/api/books/1', {}, {headers: {
      'content-type':'application/json'
    }})
    this.setState({
      id: book.id,
      name: book.name,
      author: book.author,
      publishDate: book.publishDate,
      purchaseDate: book.purchaseDate
    })
  }

  render() {
    console.log(this.state);
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            Edit <code>src/App.js</code> and save to reload.
          </p>
          <a
            className="App-link"
            href="https://reactjs.org"
            target="_blank"
            rel="noopener noreferrer"
          >
            Learn React
          </a>
        </header>
      </div>
    );
  }
}

export default App;
