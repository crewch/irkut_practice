import { Button, styled } from '@mui/material'

export const CustomButton = styled(Button)(() => ({
	borderRadius: '5px',
	backgroundColor: '#ECECEC',
	color: '#333333',
	boxShadow: 'none',
	textTransform: 'none',
	'&:hover': {
		backgroundColor: 'transparent',
	},
})) as typeof Button
