import axios from 'axios';

const headerToken = token => ({
	Authorization: `Bearer ${token}`
});

export const api = () => {
	if (!localStorage.getItem('access_token')) {
		window.location.replace(`/logIn`);
		return axios;
	}
	else {
		return axios.create({
			headers: headerToken(localStorage.getItem('access_token')),
		});
	}
};


export const apiWithoutRedirect = () => {
	if(!localStorage.getItem('access_token'))
        return axios;
	return axios.create({
		headers: headerToken(localStorage.getItem('access_token'))
	});
};